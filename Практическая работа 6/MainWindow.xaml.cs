﻿using System;
using Lib6;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практическая_работа_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Сложить_1_Пару_Чисел(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(пара1_1.Text, out int a) || !int.TryParse(пара1_2.Text, out int b))
            {
                MessageBox.Show("Введите правильно");
                return;
            }

            Pair pair = new Pair(a, b);
            pair--;

            MessageBox.Show("Сумма 1-ой пары чисел:" + pair.Sum().ToString());


        }
        private void Button_Сложить_1_Пару_Чисел_1(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(пара1_1.Text, out int a) || !int.TryParse(пара1_2.Text, out int b))
            {
                MessageBox.Show("Введите правильно");
                return;
            }

            Pair pair = new Pair(a, b);
             pair++;

            MessageBox.Show("Сумма 1-ой пары чисел:" + pair.Sum().ToString());


        }

        private void Button_Сложить_2_Пару_Чисел_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(пара2_1.Text, out int c) || !int.TryParse(пара2_2.Text, out int d))
            {
                MessageBox.Show("Введите правильно");
                return;
            }

            Pair pair = new Pair(c, d);
            pair--;

            MessageBox.Show("Сумма 2-ой пары чисел:" + pair.Sum().ToString());

        }

        private void Button_Сложить_2_Пару_Чисел_Click_1(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(пара2_1.Text, out int c) || !int.TryParse(пара2_2.Text, out int d))
            {
                MessageBox.Show("Введите правильно");
                return;
            }

            Pair pair = new Pair(c, d);
            pair++;

            MessageBox.Show("Сумма 2-ой пары чисел:" + pair.Sum().ToString());

        }

        private void Button_Сложить_Пары_Чисел(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(пара1_1.Text, out int a)
            || !int.TryParse(пара1_2.Text, out int b)
            || !int.TryParse(пара2_1.Text, out int c)
            || !int.TryParse(пара2_2.Text, out int d))
            {
                MessageBox.Show("Введите правильно");
                return;
            }

            Pair pair1 = new Pair(a, b);
            Pair pair2 = new Pair(c, d);
            Pair pair3 = pair1.Sum(pair2);
            пара3_1.Text = pair3.One.ToString();
            пара3_2.Text = pair3.Second.ToString();


        }

        private void MenuItem_Click_О_программе(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Автор: Гришина Наталия \n Практическая работа №5 \n Задание:Создать класс Pair (пара чисел). Создать необходимые методы и свойства. \r\nОпределить методы метод сложения полей и операцию сложения пар (а, b) + (с, d) \r\n= (а + c, b + d). Создать перегруженные методы для увеличения полей на 1, сложения трех пар чисел.\r\n");

        }

        private void MenuItem_Click_Выход(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_Очистить(object sender, RoutedEventArgs e)
        {
            пара1_1.Clear();
            пара1_2.Clear();
            пара2_1.Clear();
            пара2_2.Clear();
            пара3_1.Clear();
            пара3_2 .Clear();


        }
    }
}
