﻿using Xamarin.Forms;
using System;
using System.IO;
using Notes.Data;

namespace Notes
{
    public partial class App : Application
    {
        static NoteDatabase database;

        //Create the database connection as a singleton
        public static NoteDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }

       // public static string FolderPath { get; private set; }
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}