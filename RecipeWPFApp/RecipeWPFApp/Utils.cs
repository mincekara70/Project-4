﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeWPFApp
{
    /*public class CreateWindow
    {
        public static ContentPage Create(int option)
        {
            switch (option)
            {
                case 1:
                    return new MainPage();
                case 2:
                    return new BrowsePage();
                case 3:
                    return new AccountPage();
                case 4:
                    return new RegisterPage();
                default:
                    return new MainPage();
            }
        }
    }*/

    public interface Option<T>
    {
        U Visit<U>(Func<T, U> OnSome, Func<U> OnNone);
        void Visit(Action<T> OnSome, Action OnNone);
    }

    public interface Iterator<T> : System.Collections.Generic.IList<T>
    {
        Option<T> GetCurrent();
        Option<T> GetNext();
        void Reset();
    }

    public class None<T> : Option<T>
    {
        public U Visit<U>(Func<T, U> OnSome, Func<U> OnNone)
        {
            return OnNone();
        }

        public void Visit(Action<T> OnSome, Action OnNone)
        {
            OnNone();
        }
    }

    public class Some<T> : Option<T>
    {
        private T Value;

        public Some(T item)
        {
            this.Value = item;
        }

        public U Visit<U>(Func<T, U> OnSome, Func<U> OnNone)
        {
            return OnSome(this.Value);
        }

        public void Visit(Action<T> OnSome, Action OnNone)
        {
            OnSome(this.Value);
        }
    }

    public class List<T> : Iterator<T>
    {
        private System.Collections.Generic.List<T> Elements = new System.Collections.Generic.List<T>();
        public int Current = -1;

        public T this[int index] { get => this.Elements[index]; set => this.Elements[index] = value; }

        public int Count => Elements.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            this.Elements.Add(item);
        }

        public void Clear()
        {
            this.Elements.Clear();
        }

        public bool Contains(T item)
        {
            return this.Elements.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.Elements.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.Elements.GetEnumerator();
        }

        public Option<T> GetCurrent()
        {
            try
            {
                return new Some<T>(Elements[Current]);
            }
            catch (ArgumentOutOfRangeException) { return new None<T>(); }
        }

        public Option<T> GetNext()
        {
            this.Current += 1;
            return GetCurrent();
        }

        public int IndexOf(T item)
        {
            return this.Elements.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            this.Elements.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return this.Elements.Remove(item);
        }

        public void RemoveAt(int index)
        {
            this.Elements.RemoveAt(index);
        }

        public void Reset()
        {
            this.Current = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Elements.GetEnumerator();
        }
    }

    public class Recipe
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public object Beschrijving { get; set; }
        public string Ingredienten { get; set; }
        public object Voorbereiding { get; set; }
        public string Bereidingswijze { get; set; }
        public string Categorie { get; set; }
        public string Imagelink { get; set; }
        public object Valid { get; set; }
    }

    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string admin { get; set; }
    }

    public class RegisterResponse
    {
        public bool response { get; set; }
    }

    public class BookmarkItem
    {
        public string username { get; set; }
        public string recept { get; set; }
    }
    public class Average
    {
        public string beoordeling { get; set; }
    }
    public class UserRating
    {
        public string beoordeling { get; set; }
        public string recept { get; set; }
        public string username { get; set; }
    }
}
