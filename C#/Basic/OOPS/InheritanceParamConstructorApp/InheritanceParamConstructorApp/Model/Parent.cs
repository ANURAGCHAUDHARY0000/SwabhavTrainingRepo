using System;
namespace InheritanceParamConstructorApp.Model
{
    internal class Parent
    {
        private int _foo;

        public Parent(int foo)
        {
            _foo = foo;
        }

        public int GetFoo()
         { return _foo; }
    }
}
