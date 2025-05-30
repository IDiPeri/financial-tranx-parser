﻿using QuickHomeExpenseSummarizer.ViewModel;
using System.Dynamic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuickHomeExpenseSummarizer;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    ExpenseSummarizerViewModel VM;

    public MainWindow()
    {
        InitializeComponent();
        VM = new ExpenseSummarizerViewModel();
        DataContext = VM;
    }
}