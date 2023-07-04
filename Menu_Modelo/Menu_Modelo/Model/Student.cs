using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menu_Modelo.Model
{
    public class Student
    {
        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
