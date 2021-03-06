﻿namespace PoGo.NecroBot.CLI.WebSocketHandler.GetCommands.Events
{
    class ItemListResponce : IWebSocketResponce
    {
        public ItemListResponce(dynamic data,string requestID)
        {
            Command = "ItemListWeb";
            Data = data;
            RequestID = requestID;
        }
        public string RequestID { get; private set; }
        public string Command { get; private set; }
        public dynamic Data { get; private set; }
    }
}
