//2150656043 Büşra Şanlıbayrak

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class Node
    {
        public int icerik;
        public Node sag;
        public Node sol;

        public Node(int icerik)
        {
            this.icerik = icerik;
            sag = null;
            sol = null;
        }

        public void insert(Node temp,int new_element)
        {
            
            if (temp.icerik < new_element)
            {
                if (temp.sag == null) temp.sag = new Node(new_element);
                else insert(temp.sag,new_element);
            }
            else if (temp.icerik > new_element)
            {
                if (temp.sol == null) temp.sol = new Node(new_element);
                else insert(temp.sol,new_element);
            }
        }

        public void search(Node temp,int element)
        {
            if (temp.icerik == element) Console.WriteLine("Bulundu!");
            else if (temp.icerik < element)
            {
                if (temp.sag == null) Console.WriteLine("Bulunamadı!");
                else search(temp.sag,element);
            }
            else if (temp.icerik > element)
            {
                if (temp.sol == null) Console.WriteLine("Bulunamadı!");
                else search(temp.sol,element);
            }
            
        }

        public Node searchMaximum(Node temp)
        {
            if (temp.sag == null) { Console.WriteLine(temp.icerik); return temp; }
            else return searchMaximum(temp.sag);
        }

        public Node searchMinimum(Node temp)
        {

            if (temp.sol == null) { Console.WriteLine(temp.icerik); return temp; }
            else return searchMinimum(temp.sol);
        }

        public void preorder()
        {
            Console.WriteLine(icerik);
            if (sol != null)
                sol.preorder();
            if (sag != null)
                sag.preorder();
        }

    }

    public class Tree
    {
        Node root;

        public Tree()
        {
            root = null;
        }

        public void insert(int new_element)
        {
            if (root == null) root = new Node(new_element);
            else if (root.icerik < new_element)
            {
                if (root.sag == null) root.sag = new Node(new_element);
                else root.sag.insert(root.sag,new_element);
            }
            else if (root.icerik > new_element)
            {
                if (root.sol == null) root.sol = new Node(new_element);
                else root.sol.insert(root.sol,new_element);
            }
        }

        public void search(int element)
        {
            if (root.icerik == element) Console.WriteLine("Bulundu!");
            else if (root.icerik < element)
            {
                if (root.sag == null) Console.WriteLine("Bulunamadı!");
                else root.sag.search(root.sag,element);
            }
            else if (root.icerik > element)
            {
                if (root.sol == null) Console.WriteLine("Bulunamadı!");
                else root.sol.search(root.sol,element);
            }
            
        }

        public Node searchMaximum()
        {
            if (root == null) return null;
            else if (root.sag == null) return root;
            else return root.sag.searchMaximum(root.sag);
        }

        public Node searchMinimum()
        {
            if (root == null) return null;
            else if (root.sol == null) return root;
            else return root.sol.searchMinimum(root.sol);
        }

        public void delete(int element)
        {
            Node y = null, x = root;
            while (x.icerik != element)
            {
                if (x.icerik > element)
                    x = x.sol;
                else x = x.sag;
            }

            while (true)
            {
                if (x.sol != null)
                    y = x.sol.searchMaximum(x.sol);
                if (y == null && x.sag != null)
                    y = x.sag.searchMinimum(x.sag);
                if (y == null) break;
                x.icerik = y.icerik;
                x = y;
            }
            

        }

        public void preorder()
        {
            if (root.sol != null)
                root.sol.preorder();
            if (root.sag != null)
                root.sag.preorder();
        }
    }
}
