using Hotel.classes;
using NLog;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel
{
    public partial class GuestForm : Form
    {
        Logger logger = LogManager.GetCurrentClassLogger();

        private SqlConnection sqlConnection = null;

        private int guestId; 

        public GuestForm(int guestId)
        {
            InitializeComponent();
            
            this.guestId = guestId;

            LoadGuestData(guestId);
        }

        public void LoadGuestData(int guestId)
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

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                logger.Trace("В поле 'фио' вводятся данные из бд");
                nameField.Text = reader["name"] as string;

                logger.Trace("В поле 'дата рождения' вводятся данные из бд");
                birthDTime.Value = Convert.ToDateTime(reader["birth_date"]);

                logger.Trace("В поле 'оплата' вводятся данные из бд");
                chargeField.Text = reader["amount_of_payment"].ToString();

                logger.Trace("В элемент 'наличие питомца' вводятся данные из бд");
                string hasPets = reader["has_pets"].ToString();

                if (hasPets == "True")
                {
                    checkBoxPets.Checked = true;
                }
                else
                {
                    checkBoxPets.Checked = false;
                }


                ///checkBoxPets.Checked = havePet;

                logger.Trace("В поле 'количество дней' вводятся данные из бд");
                daysField.Text = reader["days_stayed"].ToString();

                if ((reader["days_stayed"] == DBNull.Value) || (reader["birth_date"] == DBNull.Value) || (reader["amount_of_payment"] == DBNull.Value) || (reader["name"] == DBNull.Value))
                {
                    logger.Warn("В базе данных обнаружены пустые поля!");
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
            logger.Info("Происходит закрытие формы 'карточка гостя'");
        }
    }
}
