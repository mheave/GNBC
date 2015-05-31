using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GNBCWeb.Data;
using GNBCWeb.Models;

namespace GNBCWeb.Services {
	public class OrderService {
		readonly GoldSilverMoneyDbDataContext gsbdbDataContext =  new GoldSilverMoneyDbDataContext();

		public void AddItemToOrderLog(OrderLogEventItem logEventEvent) {
			gsbdbDataContext.usp_addOrderLogItem(logEventEvent.SessionId, (int)logEventEvent.EventType, logEventEvent.EventDetail);
		}
	}
}