using Menu_Modelo.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Menu_Modelo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class Page1 : ContentPage
    {
        private SQLiteConnection conn;
        public Student student;
        public Page1()
        {
            
            InitializeComponent();
            conn = DependencyService.Get<ISQLIte>().GetConnection();
            conn.CreateTable<Student>();
        }

        private void ShowButton_Clicked(object sender, EventArgs e)
        {
            var data = (from stu in conn.Table<Student>() select stu);
            Datalist.ItemsSource = data;
        }

        private void ExlButton_Clicked(object sender, EventArgs e)
        {
            var student = conn.Table<Student>().First(x => x.Name == Name.Text);
            conn.Delete(student);

        }

        private void SavaButton_Clicked(object sender, EventArgs e)
        {
            student = new Student();
            student.Name = Name.Text;
            student.Address = Address.Text;
            conn.Insert(student);
            Name.Text = "";
            Address.Text = "";
        }
    }
}