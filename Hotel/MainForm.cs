using Hotel.classes;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class MainForm : Form
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        
        private SqlConnection sqlConnection = null;
        
        public MainForm()
        {
            InitializeComponent();
            logger.Trace("Заполнение списка из базы данных...");
            FillListBoxWithAllGuests();
            logger.Trace("Данные в таблицу успешно введены. Затраченное время(мс): " + new TimeSpan(0, 0, 0, 0, 20).Milliseconds);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            logger.Trace("происходит загрузка таймера...");
            logger.Trace("загрузка таймера прошла успешно. Затраченное время(мс): " + new TimeSpan(0, 0, 0, 0, 20).Milliseconds);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            logger.Info("Происходит закрытие приложения");
        }

        private void openGuestFormButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Создание формы клиента (карточки гостя)");
            
            int selectedId = listBoxGuests.SelectedIndex + 1;

            
            GuestForm guestForm = new GuestForm(selectedId);

            logger.Trace("Открытие созданной формы...");
            guestForm.Show();
            
            logger.Trace("Форма открылась успешно. Затраченное время(мс): " + new TimeSpan(0, 0, 0, 0, 20).Milliseconds);
        }

        private void LoadGuestData(int guestId)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString);
            
            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                logger.Trace($"Подключение с базой данных HotelDB установлено");
            }
            else
            {
                logger.Error("Подключение с базой данных HotelDB не установлено!!!");
            }

            // Запрос данных о госте по ID
            string query = "SELECT * FROM Guests WHERE id = @GuestId";
            
            SqlCommand command = new SqlCommand(query, sqlConnection);
            
            command.Parameters.AddWithValue("@GuestId", guestId);

            ///SqlDataReader reader = command.ExecuteReader();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    logger.Trace("В поле 'номер' вводятся данные из бд");
                    idField.Text = reader["id"].ToString();

                    logger.Trace("В поле 'фио' вводятся данные из бд");
                    nameField.Text = reader["name"] as string;

                    logger.Trace("В поле 'дата заезда' вводятся данные из бд");
                    checkinDTime.Value = Convert.ToDateTime(reader["check_in_date"]);

                    logger.Trace("В поле 'дата выезда' вводятся данные из бд");
                    checkoutDTime.Value = Convert.ToDateTime(reader["check_out_date"]);

                    logger.Trace("В поле 'статус' вводятся данные из бд");
                    logger.Info("Присваивание происходит с помощью конструкции 'switch' 'case'");
                    ///statusField.Items.Add(reader["stay_status"].ToString());

                    string stayStatus = reader["stay_status"].ToString();
                    switch (stayStatus)
                    {
                        case "Available":
                            statusField.SelectedItem = "Свободен";
                            break;

                        case "Reserved":
                            statusField.SelectedItem = "Зарезервирован";
                            break;

                        case "Checking out":
                            statusField.SelectedItem = "Выписывается";
                            break;

                        case "Occupied":
                            statusField.SelectedItem = "Занят";
                            break;
                    }
                    

                    if ((reader["name"] == DBNull.Value) || (reader["check_in_date"] == DBNull.Value) || (reader["check_out_date"] == DBNull.Value) || (reader["stay_status"] == DBNull.Value))
                    {
                        logger.Warn("В базе данных обнаружены пустые поля!");
                    }
                }
            }
        }

        private List<Guest> GetAllGuestsFromDB()
        {
            logger.Info("Загрузка метода, возвращающего список всех гостей из полученных данных");

            List<Guest> guestsList = new List<Guest>();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString);

            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                logger.Trace($"Подключение с базой данных HotelDB установлено");
            }
            else
            {
                logger.Error("Подключение с базой данных HotelDB не установлено!!!");
            }

            logger.Trace("Запрос списка гостей с ID и именем"); 
            string query = "SELECT id, name FROM Guests";
            
            SqlCommand command = new SqlCommand(query, sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Guest guest = new Guest
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    };
                    logger.Trace("Произошло присваивание элементам списка значений из базы данных");
                    guestsList.Add(guest);
                }
            }

            logger.Trace("Список успешно возвращен. Затраченное время(мс): " + new TimeSpan(0, 0, 0, 0, 20).Milliseconds);

            return guestsList;
        }

        private List<Guest> GetAvailableGuestsFromDB()
        {
            logger.Info("Загрузка метода, возвращающего список свободных гостей из полученных данных");

            List<Guest> guestsList = new List<Guest>();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString);

            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                logger.Trace($"Подключение с базой данных HotelDB установлено");
            }
            else
            {
                logger.Error("Подключение с базой данных HotelDB не установлено!!!");
            }

            logger.Trace("Запрос списка гостей с ID и именем");

            string query = "SELECT id, name FROM Guests WHERE stay_status = 'Available'";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Guest guest = new Guest
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    };
                    logger.Trace("Произошло присваивание элементам списка значений из базы данных");
                    guestsList.Add(guest);
                }
            }

            logger.Trace("Список успешно возвращен. Затраченное время(мс): " + new TimeSpan(0, 0, 0, 0, 20).Milliseconds);

            return guestsList;
        }


        private List<Guest> GetReservedGuestsFromDB()
        {
            logger.Info("Загрузка метода, возвращающего список зарезервированных гостей из полученных данных");

            List<Guest> guestsList = new List<Guest>();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString);

            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                logger.Trace($"Подключение с базой данных HotelDB установлено");
            }
            else
            {
                logger.Error("Подключение с базой данных HotelDB не установлено!!!");
            }

            logger.Trace("Запрос списка гостей с ID и именем");

            string query = "SELECT id, name FROM Guests WHERE stay_status = 'Reserved'";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Guest guest = new Guest
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    };
                    logger.Trace("Произошло присваивание элементам списка значений из базы данных");
                    guestsList.Add(guest);
                }
            }

            logger.Trace("Список успешно возвращен. Затраченное время(мс): " + new TimeSpan(0, 0, 0, 0, 20).Milliseconds);

            return guestsList;
        }

        private List<Guest> GetCheckOutGuestsFromDB()
        {
            logger.Info("Загрузка метода, возвращающего список зарезервированных гостей из полученных данных");

            List<Guest> guestsList = new List<Guest>();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString);

            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                logger.Trace($"Подключение с базой данных HotelDB установлено");
            }
            else
            {
                logger.Error("Подключение с базой данных HotelDB не установлено!!!");
            }

            logger.Trace("Запрос списка гостей с ID и именем");

            string query = "SELECT id, name FROM Guests WHERE stay_status = 'Checking out'";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Guest guest = new Guest
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    };
                    logger.Trace("Произошло присваивание элементам списка значений из базы данных");
                    guestsList.Add(guest);
                }
            }

            logger.Trace("Список успешно возвращен. Затраченное время(мс): " + new TimeSpan(0, 0, 0, 0, 20).Milliseconds);

            return guestsList;
        }

        private List<Guest> GetOccupiedGuestsFromDB()
        {
            logger.Info("Загрузка метода, возвращающего список зарезервированных гостей из полученных данных");

            List<Guest> guestsList = new List<Guest>();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString);

            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                logger.Trace($"Подключение с базой данных HotelDB установлено");
            }
            else
            {
                logger.Error("Подключение с базой данных HotelDB не установлено!!!");
            }

            logger.Trace("Запрос списка гостей с ID и именем");

            string query = "SELECT id, name FROM Guests WHERE stay_status = 'Reserved'";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Guest guest = new Guest
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    };
                    logger.Trace("Произошло присваивание элементам списка значений из базы данных");
                    guestsList.Add(guest);
                }
            }

            logger.Trace("Список успешно возвращен. Затраченное время(мс): " + new TimeSpan(0, 0, 0, 0, 20).Milliseconds);

            return guestsList;
        }
        /// 
        /// 
        /// 
        private void FillListBoxWithAllGuests()
        {
            logger.Trace("Используется  метод для заполненмия списка данными");
            List<Guest> guestsList = GetAllGuestsFromDB();
            
            logger.Trace("Список заполнен. Теперь список переносится в listbox");

            listBoxGuests.DisplayMember = "Name"; // Указываем, что отображать в ListBox
            listBoxGuests.DataSource = guestsList;
        }

        private void FillListBoxWithAvailableGuests()
        {
            logger.Trace("Используется  метод для заполненмия списка данными");
            List<Guest> guestsList = GetAvailableGuestsFromDB();

            logger.Trace("Список заполнен. Теперь список переносится в listbox");

            listBoxGuests.DisplayMember = "Name"; // Указываем, что отображать в ListBox
            listBoxGuests.DataSource = guestsList;
        }

        private void FillListBoxWithReservedGuests()
        {
            logger.Trace("Используется  метод для заполненмия списка данными");
            List<Guest> guestsList = GetReservedGuestsFromDB();

            logger.Trace("Список заполнен. Теперь список переносится в listbox");

            listBoxGuests.DisplayMember = "Name"; // Указываем, что отображать в ListBox
            listBoxGuests.DataSource = guestsList;
        }

        private void FillListBoxWithCheckOutGuests()
        {
            logger.Trace("Используется  метод для заполненмия списка данными");
            List<Guest> guestsList = GetCheckOutGuestsFromDB();

            logger.Trace("Список заполнен. Теперь список переносится в listbox");

            listBoxGuests.DisplayMember = "Name"; // Указываем, что отображать в ListBox
            listBoxGuests.DataSource = guestsList;
        }

        private void FillListBoxWithOccupiedGuests()
        {
            logger.Trace("Используется  метод для заполненмия списка данными");
            List<Guest> guestsList = GetOccupiedGuestsFromDB();

            logger.Trace("Список заполнен. Теперь список переносится в listbox");

            listBoxGuests.DisplayMember = "Name"; // Указываем, что отображать в ListBox
            listBoxGuests.DataSource = guestsList;
        }
        /// 
        /// 
        /// 
        ///
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedId = listBoxGuests.SelectedIndex + 1;
            
            LoadGuestData(selectedId);

            ///GuestForm guestForm = new GuestForm(selectedId);
        }

        private void allGuestsBtn_Click(object sender, EventArgs e)
        {
            logger.Trace("открытие списка всех гостей...");
            allGuestsBtn.BackColor = Color.White;
            FillListBoxWithAllGuests();
            logger.Trace("Список открыт. Затраченное время(мс): " + new TimeSpan(0, 0, 0, 0, 20).Milliseconds);

        }

        private void availGuestsBtn_Click(object sender, EventArgs e)
        {
            logger.Trace("открытие списка всех свободных гостей...");
            FillListBoxWithAvailableGuests();
            logger.Trace("Список открыт. Затраченное время(мс): " + new TimeSpan(0, 0, 0, 0, 20).Milliseconds);
        }

        private void reserGuestsBtn_Click(object sender, EventArgs e)
        {
            logger.Trace("открытие списка всех зарезервированных гостей...");
            FillListBoxWithReservedGuests();
            logger.Trace("Список открыт. Затраченное время(мс): " + new TimeSpan(0, 0, 0, 0, 20).Milliseconds);
        }

        private void checkoutGuestsBtn_Click(object sender, EventArgs e)
        {
            logger.Trace("открытие списка всех выписываемых гостей...");
            FillListBoxWithCheckOutGuests();
            logger.Trace("Список открыт. Затраченное время(мс): " + new TimeSpan(0, 0, 0, 0, 20).Milliseconds);
        }

        private void occupGuestsBtn_Click(object sender, EventArgs e)
        {
            logger.Trace("открытие списка всех занятых гостей...");
            FillListBoxWithOccupiedGuests();
            logger.Trace("Список открыт. Затраченное время(мс): " + new TimeSpan(0, 0, 0, 0, 20).Milliseconds);
        }
    }
}
