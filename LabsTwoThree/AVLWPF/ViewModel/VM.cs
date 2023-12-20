using AVLWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using AVLTreeLib;

namespace AVLWPF.ViewModel
{
    class VM : PChanged
    {
        private AVLTree avlTree;
        private ObservableCollection<double> treeNodes;
        private string inputValue;
        private ObservableCollection<string> printValues;

        public VM()
        {
            avlTree = new AVLTree();
            TreeNodes = new ObservableCollection<double>();

            AddCommand = new RelayCommand(AddNumber);
            DeleteCommand = new RelayCommand(DeleteNumber);
        }

        public ObservableCollection<double> TreeNodes
        {
            get { return treeNodes; }
            set
            {
                treeNodes = value;
                OnPropertyChanged();
            }
        }

        public string InputValue
        {
            get { return inputValue; }
            set
            {
                inputValue = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> PrintValues
        {
            get { return printValues; }
            set
            {
                printValues = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }

        private void AddNumber()
        {
            if (double.TryParse(InputValue, out double number))
            {
                avlTree.Insert(number);
                UpdateTreeView();
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void DeleteNumber()
        {
            if (double.TryParse(InputValue, out double number))
            {
                avlTree.Delete(number);
                UpdateTreeView();
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void UpdateTreeView()
        {
            TreeNodes.Clear();
            TraverseTree(avlTree.Root);
        }

        private void TraverseTree(AVLNode node)
        {
            List<string> treeAsStringList = avlTree.GetTreeAsStringList();
            PrintValues = new ObservableCollection<string>(treeAsStringList);
            OnPropertyChanged(nameof(PrintValues));
        }
    }
}
