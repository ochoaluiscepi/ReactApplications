using Amazon.Lambda.SNSEvents;
using HotelCreatedEventHandler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HotelCreatedEventHandler
{
    /*
    Environment.SetEnvironmentVariable("host","elasticsearch-host");
    Environment.SetEnvironmentVariable("userName","elasticsearch-host");
    Environment.SetEnvironmentVariable("password","elasticsearch-host");
    Environment.SetEnvironmentVariable("indexName","elasticsearch-host");*/
    public class HotelCreatedEventHandlerTest
    {
        public async void test()
        {
            var hotel = new Hotel()
            {
                Name = "test",
                CityName = "test",
                Price = 10,
                Id = "123",
                Rating = 4,
                UserId = "123",
                CreationDateTime = DateTime.Now,
                FileName = "test"
            };

            var snsEvent = new SNSEvent()
            {
                Records = new List<SNSEvent.SNSRecord>()
                {
                    new SNSEvent.SNSRecord()
                    {
                        Sns = new SNSEvent.SNSMessage()
                        {
                            MessageId = "100",
                             Message = JsonSerializer.Serialize(hotel)
                        }
                    }
                }

            };
            var handler = new HotelCreatedEventHandler();
            await handler.Handler(snsEvent);
        }

    }
}
