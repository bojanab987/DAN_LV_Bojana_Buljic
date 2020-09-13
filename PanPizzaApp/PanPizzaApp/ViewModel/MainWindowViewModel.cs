using PanPizzaApp.Commands;
using PanPizzaApp.Model;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PanPizzaApp.ViewModel
{
    class MainWindowViewModel:ViewModelBase
    {
        MainWindow main;
        public PanPizza pizzaModel = new PanPizza();        

        public MainWindowViewModel(MainWindow mainOpen)
        {
            main = mainOpen;

            PizzaSizeList = pizzaModel.GetAllPanPizzas();
            SideDishesForPizza = new List<SideDish>();           
        }

        #region Properties
        
        /// <summary>
        /// List of offered pizza sizes
        /// </summary>
        private List<PanPizza> pizzaSizeList;
        public List<PanPizza> PizzaSizeList
        {
            get { return pizzaSizeList; }
            set
            {
                pizzaSizeList = value;
                OnPropertyChanged("PizzaSizeList");
            }
        }

        /// <summary>
        /// Selected pizza size
        /// </summary>
        private PanPizza selectedSize;
        public PanPizza SelectedSize
        {
            get { return selectedSize; }
            set
            {
                selectedSize = value;
                OnPropertyChanged("SelectedSize");
            }
        }

        /// <summary>
        /// List of sides
        /// </summary>
        private List<SideDish> sideDishesForPizza;
        public List<SideDish> SideDishesForPizza
        {
            get { return sideDishesForPizza; }
            set
            {
                sideDishesForPizza = value;
                OnPropertyChanged("SideDishesForPizza");
            }
        }

        /// <summary>
        /// Total price preview property
        /// </summary>
        private double totalPrice = 0;
        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = value;
                OnPropertyChanged("TotalPrice");
            }
        }

        private bool canChoose = true;
        public bool CanChoose
        {
            get
            {
                return canChoose;
            }
            set
            {
                canChoose = value;
                OnPropertyChanged("CanChoose");
            }
        }
        #endregion

        #region for side dishes properties
        private SideDish salami = new SideDish("salami", 30);
        public SideDish Salami
        {
            get
            {
                return salami;
            }
            set
            {
                salami = value;
                OnPropertyChanged("Salami");
            }
        }

        private SideDish ham = new SideDish("ham", 50);
        public SideDish Ham
        {
            get
            {
                return ham;
            }
            set
            {
                ham = value;
                OnPropertyChanged("Ham");
            }
        }

        private SideDish kulen = new SideDish("kulen", 70);
        public SideDish Kulen
        {
            get
            {
                return kulen;
            }
            set
            {
                kulen = value;
                OnPropertyChanged("Kulen");
            }
        }

        private SideDish ketchup = new SideDish("ketchup", 20);
        public SideDish Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
                OnPropertyChanged("Ketchup");
            }
        }

        private SideDish mayoneese = new SideDish("mayoneese", 20);
        public SideDish Mayoneese
        {
            get
            {
                return mayoneese;
            }
            set
            {
                mayoneese = value;
                OnPropertyChanged("Mayoneese");
            }
        }

        private SideDish chilly = new SideDish("chilly", 40);
        public SideDish Chilly
        {
            get
            {
                return chilly;
            }
            set
            {
                chilly = value;
                OnPropertyChanged("Chilly");
            }
        }

        private SideDish olives = new SideDish("olives", 30);
        public SideDish Olives
        {
            get
            {
                return olives;
            }
            set
            {
                olives = value;
                OnPropertyChanged("Olives");
            }
        }

        private SideDish oregano = new SideDish("oregano", 10);
        public SideDish Oregano
        {
            get
            {
                return oregano;
            }
            set
            {
                oregano = value;
                OnPropertyChanged("Oregano");
            }
        }

        private SideDish sesame = new SideDish("sesame", 10);
        public SideDish Sesame
        {
            get
            {
                return sesame;
            }
            set
            {
                sesame = value;
                OnPropertyChanged("Sesame");
            }
        }

        private SideDish cheese = new SideDish("cheese", 30);
        public SideDish Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
                OnPropertyChanged("Cheese");
            }
        }
        #endregion


        #region Commands
        /// <summary>
        /// Command to calculate Amount
        /// </summary>
        private ICommand calculateAmount;
        public ICommand CalculateAmount
        {
            get
            {
                if (calculateAmount == null)
                {
                    calculateAmount = new RelayCommand(param => CalculateAmountExecute(), param => CanCalculateAmountExecute());
                }
                return calculateAmount;
            }
        }

        /// <summary>
        /// Method to execute calculation
        /// </summary>
        private void CalculateAmountExecute()
        {
            try
            {
                if (SelectedSize == null)
                {
                    MessageBox.Show("Please choose size of pizzaModel", "Notification");
                }
                else
                {
                    if (Salami.IsSelectedIngredient)
                    {
                        SideDishesForPizza.Add(Salami);
                    }
                    if (Ham.IsSelectedIngredient)
                    {
                        SideDishesForPizza.Add(Ham);
                    }
                    if (Kulen.IsSelectedIngredient)
                    {
                        SideDishesForPizza.Add(Kulen);
                    }
                    if (Ketchup.IsSelectedIngredient)
                    {
                        SideDishesForPizza.Add(Ketchup);
                    }
                    if (Mayoneese.IsSelectedIngredient)
                    {
                        SideDishesForPizza.Add(Mayoneese);
                    }
                    if (Chilly.IsSelectedIngredient)
                    {
                        SideDishesForPizza.Add(Chilly);
                    }
                    if (Olives.IsSelectedIngredient)
                    {
                        SideDishesForPizza.Add(Olives);
                    }
                    if (Oregano.IsSelectedIngredient)
                    {
                        SideDishesForPizza.Add(Oregano);
                    }
                    if (Sesame.IsSelectedIngredient)
                    {
                        SideDishesForPizza.Add(Sesame);
                    }
                    if (Cheese.IsSelectedIngredient)
                    {
                        SideDishesForPizza.Add(Cheese);
                    }
                    SelectedSize.Ingredients = SideDishesForPizza;
                    if(SideDishesForPizza==null)
                    {
                        MessageBox.Show("Please add ingredients for pizzaModel", "Notification");
                    }
                    else
                    {
                        TotalPrice = SelectedSize.CalculateAmount();
                        CanChoose = false;
                    }
                    
                }
                              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method to check if calculate is possible. 
        /// </summary>
        /// <returns></returns>
        private bool CanCalculateAmountExecute()
        {
            if(TotalPrice!=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private ICommand newOrder;
        public ICommand NewOrder
        {
            get
            {
                if (newOrder == null)
                {
                    newOrder = new RelayCommand(param => NewOrderExecute(), param => CanNewOrderExecute());
                }
                return newOrder;
            }
        }
        private void NewOrderExecute()
        {
            try
            {
                SideDishesForPizza = new List<SideDish>();
                SelectedSize=null;
                CanChoose = true;
                TotalPrice = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool CanNewOrderExecute()
        {
            return true;
        }

        private ICommand close;
        public ICommand Close
        {
            get
            {
                if (close == null)
                {
                    close = new RelayCommand(param => CloseExecute(), param => CanCloseExecute());
                }
                return close;
            }
        }

        private void CloseExecute()
        {
            try
            {
                MessageBox.Show("Goodbye!");
                main.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanCloseExecute()
        {
            return true;
        }
        #endregion

        #region save
        private ICommand save;
        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new RelayCommand(param => SaveExecute(), param => CanSaveExecute());
                }
                return save;
            }
        }

        private void SaveExecute()
        {
            try
            {
                StringBuilder sideIng = new StringBuilder();
                for (int i = 0; i < SideDishesForPizza.Count; i++)
                {
                    sideIng.Append(sideDishesForPizza[i].Ingredient + " ");
                }
                string message = "Order has been completed. \nPizza size: " + SelectedSize.PizzaSize + "\nSide dish ingredients: " + sideIng.ToString()+"\nTotal price: "+TotalPrice;
                MessageBox.Show(message);               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanSaveExecute()
        {
            if (!CanChoose)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

    }
}
