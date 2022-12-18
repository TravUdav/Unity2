using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerBuilder : MonoBehaviour
{
    public Burger _burger;
    public void MakeBurger()
    {
        this._burger = new Burger();

    }

    private void Start()
    {
        MakeBurger();
    }
}

    public class Ingridient
    {
        public string name { get; set; }

        public Ingridient(string name)
        {
            this.name = name;
        }
    }
    public class Burger
    {
        public Ingridient Cheese { get; set; }
        public Ingridient Ham { get; set; }
        public Ingridient Onion { get; set; }
        public Ingridient Cabbage { get; set; }
        public Ingridient Ketchap { get; set; }
        public Ingridient Mayo { get; set; }
        public Ingridient Beef { get; set; }
        public Ingridient Chicken { get; set; }
        
        public Burger SetCheese()
        {
            this.Cheese = new Ingridient("cheese");
            return this;
        }
        public Burger SetHam()
        {
            this.Ham = new Ingridient("ham");
            return this;
        }
        public Burger SetOnion()
        {
            this.Onion = new Ingridient("onion");
            return this;
        }
        public Burger SetCabbage()
        {
            this.Cabbage = new Ingridient("cabbage");
            return this;
        }
        public Burger SetKetchap()
        {
            this.Ketchap = new Ingridient("ketchap");
            return this;
        }
        public Burger SetMayo()
        {
            this.Mayo = new Ingridient("mayo");
            return this;
        }
        public Burger SetBeef()
        {
            this.Beef = new Ingridient("beef");
            return this;
        }
        public Burger SetChicken()
        {
            this.Chicken = new Ingridient("chicken");
            return this;
        }
    }


