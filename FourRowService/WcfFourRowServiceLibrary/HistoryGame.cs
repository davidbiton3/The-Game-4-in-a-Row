//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfFourRowServiceLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistoryGame
    {
        public int GameId { get; set; }
        public string UserNameOne { get; set; }
        public string UserNameTwo { get; set; }
        public System.DateTime StartingDateTime { get; set; }
        public string WinUserName { get; set; }
        public string LossUserName { get; set; }
        public int UserNameOneScore { get; set; }
        public int UserNameTwoScore { get; set; }
        public System.DateTime EndingDateTime { get; set; }
    }
}