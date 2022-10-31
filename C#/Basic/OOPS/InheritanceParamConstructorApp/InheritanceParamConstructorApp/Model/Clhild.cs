using System;

namespace InheritanceParamConstructorApp.Model
{
    internal class Child : Parent
    {
        public Child() : base(100)
        {

        }
        public Child(int _foo) : base (_foo)
        {

        }
    }
}
