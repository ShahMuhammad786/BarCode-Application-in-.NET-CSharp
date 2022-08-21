using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarCodeWizFontsNet;

namespace BarCodeApplication
{
    public partial class ProduntSelling : Form
    {
        public ProduntSelling()
        {
            InitializeComponent();
        }


        /*Buy Item tab : this is for the focus of text boxes to have by default 
             texts like Enter Name... etc
        */
        private void txtBuyItem_Enter(object sender, EventArgs e)
        {
            this.txtBuyItem.Text = "";
        }

        private void txtBuyItem_Leave(object sender, EventArgs e)
        {
            if (this.txtBuyItem.Text == "")
            {
                this.txtBuyItem.Text = "Enter Name...";
            }
            
        }

        //Products tab : these are the events for focus on the text boxes
        // to add the default text like Enter Name... etc.
        private void txtName_Enter(object sender, EventArgs e)
        {
            this.txtName.Text = "";
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if(this.txtName.Text == "")
                this.txtName.Text = "Enter Name...";
        }

        private void txtBarCode_Enter(object sender, EventArgs e)
        {
            this.txtBarCode.Text = "";
        }

        private void txtBarCode_Leave(object sender, EventArgs e)
        {
            if(this.txtBarCode.Text =="")
                this.txtBarCode.Text = "Enter barcode...";
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            this.txtPrice.Text = "";
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if(this.txtPrice.Text == "")
                this.txtPrice.Text = "Enter Price...";
        }

        /*This is the add button logic in the product tab
            that will add items when the textboxes is not 
            empty, otherwise it will show message that fill the feilds.
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "Enter Name..." && txtBarCode.Text != "Enter barcode..." && txtPrice.Text !="Enter Price...")
            {
                /*This will append the text to the existing text in a file
                    we are giving the whole path of the file because the file 
                    will be created int the same directory where there is the project files.
                */
                string text = this.txtName.Text + "," + this.txtBarCode.Text + "," + this.txtPrice.Text + "\n";
                File.AppendAllText("data.txt", text);
                MessageBox.Show("Item added successfully!");

                //read the updated data from the file. so firstly we have to remove the data first.
                //read file and get barcode.
                this.label3.Text = "";
                this.label4.Text = "";
                using (StreamReader sr = new StreamReader("data.txt"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached.
                    int i = 1;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] token = line.Split(','); // spliting line from file

                        //creating label and assigning a barcode.
                        // Label label = new Label();
                        Code128Fonts encode = new Code128Fonts();
                        this.label4.Font = new Font("BCW_Code128B_2", 18);
                        this.label4.Text += "(" + i + ")" + encode.Code128B(token[1]) + "\n\n";
                        this.label3.Text += i + ")         " + token[0] + "             " + token[2] + "        \n\n\n";

                        i++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields !");
            }
        }

        /*
        This is the barcode generation.
        For this: you have to do some steps:
        1. you have to go to the BarCodeApplication -> bin -> debug.
        2. There is a file 'BarCodeWiz_Code128_Fonts_Trial', you have to install
            that first.
        3. Then go to the referencec file of your project in the solution explorer, 
            and right click on that and then click 'Browse' to add reference
            Once you click that, go to this 'Documents\BarCodeWiz Examples\Code 128 Barcode Fonts\DotNet\CSHARP'
            path and choose 'BarCodeWizFontsNet.dll' file and click add.        
        */


        /*
            This is the event trigerred when the form is loaded.        
            This is the method to generate the bar code. This will read the file 
            having all the barcodes we have entered in the application to save.
            It will read the barcodes from the file and then will generate a bar code 
            and will display to the user.
        */
        private void ProduntSelling_Load(object sender, EventArgs e)
        {
            //read file and get barcode.
            using (StreamReader sr = new StreamReader("data.txt"))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached.
                int i = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] token = line.Split(','); // spliting line from file

                    //creating label and assigning a barcode.
                   // Label label = new Label();
                    Code128Fonts encode = new Code128Fonts();
                    this.label4.Font = new Font("BCW_Code128B_2", 18);
                    this.label4.Text += "("+i+")"+ encode.Code128B(token[1])+"\n\n";
                    this.label3.Text += i+")         "+token[0] + "             " + token[2]+"        \n\n\n";

                    i++;
                }
            }
        }

        //This is the button of buy when we click on the buy button these oprations will be done.
        private void btnBuyScan_Click(object sender, EventArgs e)
        {
            //Firstly we have to clear remains.txt
            File.WriteAllText("remains.txt",""); 

            //read file and get barcode.
            bool flag = false;
            using (StreamReader sr = new StreamReader("data.txt"))
            {
                string line;


                // Read and display lines from the file until 
                // the end of the file is reached.
                int i = 1; int count = 0;             
                while ((line = sr.ReadLine()) != null)
                {
                    string[] token = line.Split(','); // spliting line from file

                    //creating label and assigning a barcode.
                    // Label label = new Label();
                    if (token[0]==this.txtBuyItem.Text) // If the name of the item is found
                    {
                        Code128Fonts encode = new Code128Fonts();
                        this.label6.Font = new Font("BCW_Code128B_2", 18);
                        this.label6.Text += "(" + i + ")" + encode.Code128B(token[1]) + "\n\n";
                        this.label5.Text += i + ")         " + token[0] + "             " + token[2] + "        \n\n\n";
                        flag = true;
                        i++; count++;

                        //Update the price label
                        double price = Convert.ToDouble(token[2]);
                        double prePrice = Convert.ToDouble(this.label2.Text);
                        double updPrice = price + prePrice;
                        this.label2.Text = updPrice+"";
                        
                    }
                    else // if name of the item is not found
                    {
                        flag = false;
                        
                        //Making log of remaining items
                        /*This will append the text to the existing text in a file
                            we are giving the whole path of the file because the file 
                            will be created int the same directory where there is the project files.
                        */
                        string text = token[0] + "," + token[1] + "," + token[2] + "\n";
                        File.AppendAllText("remains.txt", text);
                    }

                }
                if (flag==false && count==0) // if the name not found
                {
                    MessageBox.Show("Item not present !");
                }
            }

        }
        
        //This is the refresh button that will reload updated data after purchasing.
        private void button1_Click(object sender, EventArgs e)
        {
            this.label3.Text = "";
            this.label4.Text = "";
            //read file and get barcode.
            using (StreamReader sr = new StreamReader("data.txt"))
            {
                string line;

                // Read and display lines from the file until 
                // the end of the file is reached.
                int i = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] token = line.Split(','); // spliting line from file

                    //creating label and assigning a barcode.
                    // Label label = new Label();
                    Code128Fonts encode = new Code128Fonts();
                    this.label4.Font = new Font("BCW_Code128B_2", 18);
                    this.label4.Text += "(" + i + ")" + encode.Code128B(token[1]) + "\n\n";
                    this.label3.Text += i + ")         " + token[0] + "             " + token[2] + "        \n\n\n";

                    i++;
                }
            }
        }

        //This is the Buy button , to buy items after scanning.
        private void btnBuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have purchased the scaned Items.\n" +
                "Total Price is = "+ this.label2.Text);
            //Now make the cart clear
            this.label5.Text = "";
            this.label6.Text = "";
            this.label2.Text = "0.00";

            //Updating the data file
            FileInfo fi = new FileInfo("remains.txt");
            if (fi.Exists)
            {
                File.Delete("data.txt"); //deleting original file
                fi.MoveTo("data.txt");//renaiming the remains.txt fila as data.txt;
            }

        }
    }
}
