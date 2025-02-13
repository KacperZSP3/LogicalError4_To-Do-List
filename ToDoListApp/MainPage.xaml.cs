﻿namespace ToDoListApp;
//Dodawanie zadań do listy
public partial class MainPage : ContentPage
{
    List<string> tasks = new List<string>();

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnAddTaskClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(TaskEntry.Text))
        {
            tasks.Add(TaskEntry.Text);
            TaskEntry.Text = "";
            TaskListView.ItemsSource = tasks;
        }
    }
}
