// using System;

// /*
// https://www.codewars.com/kata/678a4ce740343f67dcea893a/train/csharp

// */
// public class Component
// {
//   private string _id;
//   private Component _parent;
//   private Component[] _children;
//   private bool? _visibility;


//   public Component(string id, Component[] children)
//   {
//     _id = id;
//     _children = children;
//     _visibility = null; // ?
//     _parent = null;     // ?
//     foreach (var child in _children)
//     {
//       if (child != null)
//       {
//         child._parent = this; // Set parent for each child
//       }

//     }

//   }
//   public bool? Visibility
//   {
//     set { _visibility = value; }
//     get
//     {
//       //  Bug fix required.
//       return _visibility.HasValue ? _visibility.Value : _parent?._visibility.HasValue == true ? _parent._visibility.Value : true;
//     }
//   }

//   public override string ToString()
//   {
//     return _id;
//   }

// }
