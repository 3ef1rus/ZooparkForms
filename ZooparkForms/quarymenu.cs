using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using zoopark;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZooparkForms
{
    public partial class quarymenu : Form
    {
        Database database = new Database();
        Database databaseClone = new Database();
        public quarymenu()
        {
            InitializeComponent();
        }
        private List<string> nameColumnList()
        {
            List<string> name=null;
            switch (comboBoxTables.Text)
            {
                case "1":
                    name = new List<string>() { "Full name", "Job", "Experience", "Sex" , "Age", "Salarity" };
                    break;
                case "2":
                    name = new List<string>() { "Full name", "Name", "Date start" , "Date end" };
                    break;
                case "3":
                    name = new List<string>() { "Full name", "Job", "Access", "Name type" };
                    break;
                case "4":
                    name = new List<string>() { "Animal name", "Name type", "Number cell", "Hight", "Weigth", "Sex", "Data Birth", "Date join" };
                    break;
                case "5":
                    name = new List<string>() { "Warm", "Name type", "Animal name" };
                    break;
                case "6":
                    name = new List<string>() { "Date join", "Sex", "Childs", "Animal Name","Date Vaccination"};
                    break;
                case "7":
                    name = new List<string>() { "Animal name", "Name type", "Move" };
                    break;
                case "8":
                    name = new List<string>() { "Name", "Type feed", "Delivery period", "Amount" };
                    break;
                case "9":
                    name = new List<string>() { "Amount", "Name"};
                    break;
                case "10":
                    name = new List<string>() { "Name type", "Food type"};
                    break;
                case "11":
                  name = new List<string>() { "Hight","Weigth","Name","Data Birth","Date join","Child","Vaccinations","Diseases" };
                    break;
                case "12":
                    name = new List<string>() { "Number exchange", "Date exchange", "Whom give", "Whom take", "Zoopark exchange" };
                    break;
            }


            return name;
        }
        private string nameTable()
        {
            string name="";
            switch (comboBoxTables.Text)
            {
                case "1":
                    name = "Employee,Jobs";
                    break;
                case "2":
                    name = "Employee, PassportAnimal, Responsibility, ResponsibilityList";
                    break;
                case "3":
                    name = "Employee,Types,Jobs,Access";
                    break;
                case "4":
                    name = "Animal,PassportAnimal,Types,Cells";
                    break;
                case "5":
                    name = "Animal,Types,PassportAnimal";
                    break;
                case "6":
                    name = "Animal,MedicalCard,Vaccinations,VaccinationsList,PassportAnimal";
                    break;
                case "7":
                    name = "Animal,Types,PassportAnimal";
                    break;
                case "8":
                    name = "Suppliers";
                    break;
                case "9":
                    name = "Suppliers,Feeds";
                    break;
                case "10":
                    name = "Types,FoodTypes";
                    break;
                case "11":
                    name = "Animal,PassportAnimal,MedicalCard";
                    break;
                case "12":
                    name = "ZooparkForTrade,Exchanges";
                    break;
            }
            return name;
        }
        private string selectnameColumn()
        {
            string name = "";
            switch (comboBoxTables.Text)
            {
                case "1":
                    name = "Employee.[Full name],[Job]=Jobs.Name,Employee.Experience,Employee.Sex,Employee.Age,Employee.Salarity";
                    break;
                case "2":
                    name = "Employee.[Full name], PassportAnimal.Name, Responsibility.[Date start],Responsibility.[Date end]";
                    break;
                case "3":
                    name = "Employee.[Full name],[Job]=Jobs.Name,Access.[Access],Types.[Name type]";
                    break;
                case "4":
                    name = "PassportAnimal.Name,Types.[Name type],Cells.[Number cell],Animal.Hight,Animal.Weigth,PassportAnimal.Sex,PassportAnimal.[Data Birth],Animal.[Date join]";
                    break;
                case "5":
                    name = "Animal.Warm,Types.[Name type],[Animal name]=PassportAnimal.Name";
                    break;
                case "6":
                    name = "Animal.[Date join],PassportAnimal.Sex,PassportAnimal.Childs,[Animal Name]=PassportAnimal.Name, [Date Vaccination]=VaccinationsList.[Date]";
                    break;
                case "7":
                    name = "[Animal name]=PassportAnimal.Name ,Types.[Name type] , Animal.[Move]";
                    break;
                case "8":
                    name = "Suppliers.Name,Suppliers.[Type feed],Suppliers.Price, Suppliers.[Delivery period], Suppliers.Amount ";
                    break;
                case "9":
                    name = "Suppliers.Amount,Feeds.Name";
                    break;
                case "10":
                    name = "Types.[Name type],FoodTypes.[Food type] ";
                    break;
                case "11":
                    name = "Animal.Hight,Animal.Weigth,[Animal name]=PassportAnimal.Name,PassportAnimal.[Data Birth],Animal.[Date join],PassportAnimal.Childs,'',''";
                    break;
                case "12":
                    name = "Exchanges.[Number exchange],Exchanges.[Date exchange],Exchanges.[Whom give],Exchanges.[Whom take] ,[Zoopark exchange]=ZooparkForTrade.Name ";
                    break;
            }
            return name;
        }
        private string quaryWhere()
        {
            string name = "";
            switch (comboBoxTables.Text)
            {
                case "1":
                    name = "WHERE Jobs.jobID=Employee.jobID";
                    break;
                case "2":
                    name = "WHERE ResponsibilityList.employeeID=Employee.employeeID and Responsibility.responsibilityID=ResponsibilityList.responsibilityID and Responsibility.passportAnimaID=PassportAnimal.passportAnimaID AND PassportAnimal.Name='"+textBox_Quary.Text+"'";
                    break;
                case "3":
                    name = "WHERE  ( Employee.[employeeID]=Access.[employeeID] AND Types.[typeID]=Access.[typeID]) and Jobs.jobID=Employee.jobID AND  Types.[Name type]='" + textBox_Quary.Text + "'";
                    break;
                case "4":
                    name = "WHERE Animal.passportAnimaID=PassportAnimal.passportAnimaID AND PassportAnimal.typeID=Types.typeID AND Animal.cellID=Cells.cellID";
                    break;
                case "5":
                    name = "WHERE Types.[Name type]='"+ textBox_Quary.Text + "'"+" AND Types.typeID = PassportAnimal.typeID AND  PassportAnimal.passportAnimaID = Animal.passportAnimaID";
                    break;
                case "6":
                    name = "WHERE Vaccinations.Name='"+ textBox_Quary.Text + "'"+" AND Vaccinations.vaccinationID=VaccinationsList.vaccinationID AND VaccinationsList.idMedCard=MedicalCard.medicalCardID AND MedicalCard.medicalCardID=PassportAnimal.MedicalCardID AND PassportAnimal.passportAnimaID=Animal.passportAnimaID";
                    break;
                case "7":
                    name = "WHERE  Animal.[Move]='"+ textBox_Quary.Text + "'"+" AND Animal.passportAnimaID=PassportAnimal.passportAnimaID AND PassportAnimal.typeID=Types.[typeID]";
                    break;
                case "8":
                    name = "";
                    break;
                case "9":
                    name = "WHERE Suppliers.Name='"+ textBox_Quary.Text + "'"+" AND Suppliers.[supplierID]=Feeds.supplierID";
                    break;
                case "10":
                    name = "WHERE FoodTypes.foodTypeID=Types.foodTypeID ";
                    break;
                case "11":
                    name = "WHERE PassportAnimal.Name='"+ textBox_Quary.Text + "'"+"  AND PassportAnimal.passportAnimaID=Animal.passportAnimaID AND PassportAnimal.MedicalCardID=MedicalCard.medicalCardID UNION all SELECT '','','','','','',Vaccinations.Name as Vaccinations,'' FROM Vaccinations,VaccinationsList,MedicalCard,PassportAnimal WHERE   PassportAnimal.Name='"+ textBox_Quary.Text + "'"+"  AND PassportAnimal.MedicalCardID=MedicalCard.medicalCardID AND MedicalCard.medicalCardID=VaccinationsList.idMedCard AND VaccinationsList.vaccinationID=Vaccinations.vaccinationID UNION all SELECT '','','','','','','',Disease.Name as Diseases FROM Disease,DiseaseList ,MedicalCard,PassportAnimal WHERE PassportAnimal.Name='"+ textBox_Quary.Text + "'"+"  AND PassportAnimal.MedicalCardID=MedicalCard.medicalCardID AND MedicalCard.medicalCardID=DiseaseList.idMedCard AND DiseaseList.diseaseID=Disease.diseaseID";
                    break;
                case "12":
                    name = "WHERE Exchanges.zooparkID=ZooparkForTrade.zooparkID";
                    break;
            }
            return name;
        }
        private void CreateColumns()
        {
            dataGridView1.Refresh();
            dataGridView1.Rows.Clear();  // удаление всех строк
            int count = dataGridView1.Columns.Count;
            for (int i = 0; i < count; i++)     // цикл удаления всех столбцов
            {
                dataGridView1.Columns.RemoveAt(0);
            }
            List<string> name = nameColumnList();

            for (int i = 0; i < name.Count; i++)
            {
                dataGridView1.Columns.Add("", name[i]);
            }
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            List<string> name = nameColumnList();
            int length=name.Count;
            object[] row1 = new object[length + 1];

            for (int i = 0; i <= length - 1; i++)
            {
                try
                {

                    row1.SetValue(record.GetString(i), i);
                }
                catch
                {
                    try
                    {
                        row1.SetValue(record.GetInt32(i).ToString(), i);
                    }
                    catch
                    {
                        row1.SetValue(record.GetDateTime(i).ToString(), i);
                    }
                }

            }
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.CreateCells(dgw);
            dataGridViewRow.SetValues(row1);
            dgw.Rows.Add(dataGridViewRow);

        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            
            string quaryStr = $"select {selectnameColumn()} from {nameTable()} {quaryWhere()}"; 
   


            SqlCommand command = new SqlCommand(quaryStr, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            database.closeConnection();
        }
        private void bnt_refresh_Click(object sender, EventArgs e)
        {
            CreateColumns();
            UpdateQuary();
            RefreshDataGrid(dataGridView1);
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string column = "";
            List<string> name = nameColumnList();
            var table = comboBoxTables.Text;

            for (int i = 1; i < name.Count; i++)
            {
                if (column == "")
                {
                    column = column + " [" + name[i] + "] ";
                }
                else { column = column + " , [" + name[i] + " ] "; }
            }

            string searchquary = $"select * from {table} where concat ({column}) like '%" + textBoxSearch.Text + "%'";

            SqlCommand command = new SqlCommand(searchquary, database.getConnection());

            database.getConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

            database.closeConnection();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
           Search(dataGridView1);
        }
        private void quarymenu_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateQuary()
        {
            switch (comboBoxTables.Text)
            {
                case "1":
                    label_opis.Text = "Получить список служащих зоопаpка, по продолжительсти pаботы в зоопаpке, по половому пpизнаку,\r\n возpасту, pазмеpу заpаботной платы.";
                    break;
                case "2":
                    label_opis.Text = "Получить перечень , ответственных за указанный вид животныхлибо за конкpетную особь за все вpемя пpебывания \r\n животного в зоопаpке, за указанный пеpиод вpемени.";
                    break;
                case "3":
                    label_opis.Text = "Получить список , имеющих доступ к указанному виду животных либо к конкpетной особи.";
                    break;
                case "4":
                    label_opis.Text = "Получить перечень всех животных в зоопаpке либо животных указанного вида, живших\r\nв указанной клетке все вpемя пpебывания в зоопаpке, по половому пpизнаку, возpасту, весу, pосту.";
                    break;
                case "5":
                    label_opis.Text = "Получить перечень нуждающихся в теплом помещении на зиму, полностью животных\r\nтолько указанного вида или указанного возpаста.";
                    break;
                case "6":
                    label_opis.Text = "Получить перечень животных, котоpым поставлена указанная пpививка, либо\r\nпеpеболевших некоторой болезнью, по длительности пpебывания в зоопаpке, половому пpизнаку,\r\nвозpасту, пpизнаку наличия и количеству потомства.";
                    break;
                case "7":
                    label_opis.Text = "Получить перечень всех животных, совместимых с указанным видом, либо только тех животных,\r\nкотоpых необходимо пеpеселить, или тех, котоpые нуждаются в теплом помещении.";
                    break;
                case "8":
                    label_opis.Text = "Получить перечень поставщиков коpмов полностью, либо поставляющих только\r\nопpеделенный коpм, поставлявших в указанный пеpиод, по количеству поставляемого коpма, цене,\r\nдатам поставок.";
                    break;
                case "9":
                    label_opis.Text = "Получить перечень и объем коpмов, пpоизводимых зоопаpком полностью, либо только тех коpмов, в\r\nпоставках котоpых зоопаpк не нуждается (обеспечивает себя сам).";
                    break;
                case "10":
                    label_opis.Text = "Получить перечень животных полностью, либо указанного вида, котоpым необходим\r\nопределенный тип коpмов, в указанном сезоне, возpасте или кpуглый год.";
                    break;
                case "11":
                    label_opis.Text = "Получить полную инфоpмацию (pост, вес, пpививки, болезни, дата поступления в зоопаpк или дата\r\npождения, возpаст, количество потомства) о всех животных, или о животных только данного вида, о\r\nконкретном животном, об особи, живущей в указанной клетке.";
                    break;
                case "12":
                    label_opis.Text = "Получить перечень зоопаpков, с котоpыми был пpоизведен обмен животными в целом\r\nили животными только указанного вида.";
                    break;
            }

        }
    }
}
