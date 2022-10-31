using System;
using GuitarApp.Model;

namespace GuitarApp.Service
{
    internal class GuitarSpec
    {
        private Builder _builder;
        private String _model;
        private GuitarType _type;
        private BackWood _backWood;
        private TopWood _topWood;
        private int _numStrings;

        public GuitarSpec(Builder builder, String model, GuitarType type, BackWood backWood,
          TopWood topWood, int numStrings)
        {
            this._builder = builder;
            this._model = model;
            this._type = type;
            this._backWood = backWood;
            this._topWood = topWood;
            this._numStrings = numStrings;

        }

        public Builder Builder { get { return _builder; } }
        public String Model { get { return _model.ToUpper(); } }
        public GuitarType GuitarType { get { return _type; } }
        public BackWood BackWood { get { return _backWood; } }
        public TopWood TopWood { get { return _topWood; } }
        public int NumString { get { return _numStrings; } }


        public bool Matches(GuitarSpec otherSpec)
        {
            if (Builder != otherSpec._builder)
                return false;
            if ((_model != null) && (!_model.Equals("")) && (!_model.Equals(otherSpec._model)))
                return false;
            if (GuitarType != otherSpec._type)
                return false;
            if (NumString != otherSpec._numStrings)
                return false;
            if (BackWood != otherSpec._backWood)
                return false;
            if (TopWood != otherSpec._topWood)
                return false;
            return true;

        }
    }

    
}
