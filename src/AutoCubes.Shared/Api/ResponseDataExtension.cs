namespace AutoCubes.Shared.Api
{
    public static class ResponseDataExtension
    {
        public static ApiResponse AddData(this ApiResponse responseData, object obj)
        {
            responseData.ResponseData = CreateResponseDataObj(responseData.ResponseData);
            responseData.ResponseData.Data = obj;
            return responseData;
        }

        static ResponseData CreateResponseDataObj(this ResponseData responseData)
        {
            if(responseData == null)
            {
                responseData = new ResponseData();
            }
            return responseData;
        }

        public static ApiResponse AddMessage(this ApiResponse responseData, string message, string type)
        {
            responseData.ResponseData = CreateResponseDataObj(responseData.ResponseData);
            if(responseData.ResponseData.Messages == null)
            {
                responseData.ResponseData.Messages = new List<Message> { new Message { MessageText = message, MessageType = type } };
            }
            else
            {
                responseData.ResponseData.Messages.Add(new Message { MessageText = message, MessageType = type });
            }
            return responseData;
        }

        public static ApiResponse AddWarningMessage(this ApiResponse responseData, string message)
        {
            AddMessage(responseData, message, "warning");
            return responseData;
        }

        public static ApiResponse AddSuccessMessage(this ApiResponse responseData, string message)
        {
            AddMessage(responseData, message, "success");
            return responseData;
        }
    }
}
