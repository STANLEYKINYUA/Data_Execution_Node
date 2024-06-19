using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cAlgo.API;
using cAlgo.API.Collections;
using cAlgo.API.Indicators;
using cAlgo.API.Internals;

namespace cAlgo.Robots
{
    [Robot(AccessRights = AccessRights.None)]
    public class cTrader_Node : Robot
    {
        [Parameter(DefaultValue = "")]
        public string Node_Name { get; set; }

        [Parameter(DefaultValue ="192.192.192.192")]
        public string Server_IpAdress{get; set;}

        [Parameter(DefaultValue =12000)]
        public int Server_Port{get; set;}


        /*Start the cTrader Node*/


        protected override void OnStart()
        {
            /*Message that indicates that cTrader node has been Started Successfully. */
            Print("cTrader Node Started Successfully");

            //Server that handles all Connections.
            public class Server_Node()
            {
                //Default Constructor
                public Server_Node(){}

            }

            /*Start Node that Connects to Server*/
            public Node = new Server_Node();

           
    
        
        }

        protected override void OnTick()
        {
            // Handle price updates here
        }

        protected override void OnBar()
        {
        }

        protected override void OnStop()
        {
            // Handle cBot stop here

            //Send Message to Server saying it has stopped.
        }


        #region 

        //============================================================================
        /* Code that Operates the Nodes Functionality.*/
        public void Connect_to_Server(String Server_address)
        {
        }

        public void Disconnect(){}
        public void Reconnect_toServer(){}

        //============================================================================
        /* Data Transmission Functions*/
        public void Fetch_Bars(){}
        public void Load_More_History(){}
 
        //============================================================================
        /* Functions that deal with the Transmission of Data to the Server*/

        public void update_Server_AccountBalance(){}
        public void update_Server_AccountEquity(){}
        public void update_Server_OpenPositionsList(){}
        public void update_Server_ClosedPositionsList(){}
        //============================================================================

        //============================================================================
        /* Functions that Handle Trades*/

        public void Open_Trade(char Direction , String Symbol, String Trade_Label){}
        public void Close_Trade(String Trade_Label){}

        public void Fetch_Open_Positions(){}
        public string Fetch_Previously_Closed_Position_Data()
        {
            String Previous_Position_Data ="";

            // return :  P/L + Trade Size 
            return Previous_Position_Data;
        }
        //============================================================================

 
 
 
        #endregion


    }
}