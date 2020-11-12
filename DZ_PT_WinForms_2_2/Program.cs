﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Задание 2
Написать приложение – анкету, которую предлагается заполнить пользователю: имя, фамилия, e-mail, телефон.
После нажатия на кнопку «Добавить» информация о пользователе попадает в ListBox,
в котором храниться информация о всех пользователях.
Также, в ListBox, по клику на строку с информацией о пользователе следует предусмотреть возможность
удаления пользователя из коллекции элементов ListBox, а также редактирования.
Редактирование информации о пользователе производиться путем подстановки данных из ListBox,
в соответствующие поля для ввода новой информации.
   Предусмотреть:
■■ экспорт/импорт всей информации о пользователях в текстовый файл;
■■ экспорт/импорт всей информации о пользователях в *.xml файл.*/
namespace DZ_PT_WinForms_2_2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}