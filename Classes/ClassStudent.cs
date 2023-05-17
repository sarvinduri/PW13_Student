using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePracWork13.Classes
{
    internal class ClassStudent
    {
        // Предметная область: Библиотека.Минимальный список характеристик: 
        //	номер читательского билета, 
        //	ФИО читателя,
        //	адрес,
        //	телефон, 
        //	название книги,
        //	дата выдачи книги читателю,
        //	дата сдачи книги читателем.

        //поля класса
        string fullname;
        string numbergroup;
        string oap;
        string mdk;
        string math;
        string english;
        string tsi;

        //свойства для доступа к полям
        public string Fullname { get { return fullname; } set { fullname = value; } }
        public string Numbergroup
        { get { return numbergroup; } set { numbergroup = value; } }
        public string Oap
        { get { return oap; } set { oap = value; } }
        public string Mdk
        { get { return mdk; } set { mdk = value; } }
        public string Math
        { get { return math; } set { math = value; } }
        public string English
        { get { return english; } set { english = value; } }
        public string Tsi
        { get { return tsi; } set { tsi = value; } }

        //конструкторы
        public ClassStudent()
        {
            fullname = string.Empty;
            numbergroup = string.Empty;
            oap = string.Empty;
            mdk = string.Empty;
            math = string.Empty;
            english = string.Empty;
            tsi = string.Empty;
        }
        public ClassStudent(string fname, string ngroup, string oap,
        string mdk, string math, string engl, string tsi)
        {
            fullname = fname;
            numbergroup = ngroup;
            oap = oap;
            mdk = mdk;
            math = math;
            english = engl;
            tsi = tsi;
        }
    }
}
