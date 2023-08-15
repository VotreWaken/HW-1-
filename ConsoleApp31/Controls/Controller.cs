using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp31.Models;
namespace ConsoleApp31.Controls
{
    internal class Controller
    {
        DataBase database_ = new DataBase();
        public void Show()
        {
            database_.Show();
        }
        public void ShowName()
        {
            database_.ShowName();
        }
        public void ShowColors()
        {
            database_.ShowColors();
        }
        public void MaxCalories()
        {
            database_.MaxCalories();
        }
        public void MinCalories()
        {
            database_.MinCalories();
        }
        public void AvgCalories()
        {
            database_.AvgCalories();
        }
        public void ShowCountVegetables()
        {
            database_.ShowCountVegetables();
        }
        public void ShowCountFruits()
        {
            database_.ShowCountFruits();
        }
        public void ShowCountFruitsAndVegetablesByChooseColor(string color)
        {
            database_.ShowCountFruitsAndVegetablesByChooseColor(color);
        }
        public void ShowCountEveryColor()
        {
            database_.ShowCountEveryColor();
        }
        public void ShowFruitsVegetablesUnderCalories()
        {
            database_.ShowFruitsVegetablesUnderCalories();
        }
        public void ShowFruitsVegetablesUpperCalories()
        {
            database_.ShowFruitsVegetablesUpperCalories();
        }
        public void ShowFruitsVegetablesByDiapasonCalories()
        {
            database_.ShowFruitsVegetablesByDiapasonCalories();
        }
        public void ShowFruitsVegetablesWithRedYellowColor()
        {
            database_.ShowFruitsVegetablesWithRedYellowColor();
        }
    }
}
