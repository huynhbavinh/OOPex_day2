using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPex
{
    class book
    {
        private string Name;
        private author[] authors;
        private double Price;
        private int qty;

        public book(string name,author[] authors,double price,int qty =0)
        {
            this.Name = name;
            this.authors = authors;
            this.Price = price;
            this.qty = qty;
        }
        public string GetName()
        {
            return this.Name;
        }
        public author[] GetAuthor()
        {
            return this.authors;
        }
        public double GetPrice()
        {
            return this.Price;
        }
        public void SetPrice(double price)
        {
            this.Price = price;
        }
        public int GetQty()
        {
            return this.qty;
        }
        public void SetQty(int qty)
        {
            this.qty = qty;
        }
        public override string ToString()
        {
            string [] strAuthors = new string[this.authors.Length];
            for (int i = 0; i < strAuthors.Length; i++)
            {
                strAuthors[i] = this.authors[i].ToString();
            }
            return String.Format("Book [ name={0},{1},price={2},qty{3}]",this.Name,String.Join(",",strAuthors),this.Price,this.qty);
        }
        public string GetAuthorsName()
        {
            string[] strAuthors = new string[this.authors.Length];
            for (int i = 0; i < strAuthors.Length; i++)
            {
                strAuthors[i] = this.authors[i].ToString();
            }
            return String.Join(",", strAuthors);
        }
    }
}
