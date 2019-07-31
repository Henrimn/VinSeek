﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeeSchema;

namespace VinSeek.Model
{
    public class ParseResult
    {
        private ObservableCollection<ParseResult> _children = new ObservableCollection<ParseResult>();
        private string _name;
        private string _typename;
        private string _value;
        private string _position;
        private int _size;
        public ObservableCollection<ParseResult> Children
        {
            get { return _children; }
            set
            {
                _children = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public string TypeName
        {
            get { return _typename; }
            set
            {
                _typename = value;
            }
        }
        public string Value
        {
            get { return _value; }
            set
            {
                _value = value;
            }
        }
        public string Position
        {
            get { return _position; }
            set
            {
                _position = value;
            }
        }
        public int Size
        {
            get { return _size; }
            set
            {
                _size = value;
            }
        }
    }
}
