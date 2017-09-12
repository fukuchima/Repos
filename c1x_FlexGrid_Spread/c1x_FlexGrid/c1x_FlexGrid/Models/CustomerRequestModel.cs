using System;
using System.Collections.ObjectModel;

namespace c1x_FlexGrid
{
    public class CustomerRequest
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public DateTime OpenDate { get; set; }
        public string Note { get; set; }
    }
    public class CustomerRequestCollection
    {
        private ObservableCollection<CustomerRequest> _requests;
        public CustomerRequestCollection()
        {
            _requests = new ObservableCollection<CustomerRequest>
            {
                new CustomerRequest(){Title="新機能の使用方法についてご質問",OpenDate=DateTime.Today.AddDays(0) },
                new CustomerRequest(){Title="登録ボタンのデザイン更新のご依頼",OpenDate=DateTime.Today.AddDays(0),Note="【至急】案件です。" },
                new CustomerRequest(){Title="確認済みの案件の表示書式について",OpenDate=DateTime.Today.AddDays(-1)},
                new CustomerRequest(){Title="新しいバージョンの公開時期",OpenDate=DateTime.Today.AddDays(-2)},
                new CustomerRequest(){Title="更新前に比べて高速になりました",OpenDate=DateTime.Today.AddDays(-7)},
                new CustomerRequest(){Title="先日のご質問について",OpenDate=DateTime.Today.AddDays(-10)},
                new CustomerRequest(){Title="使用方法の勉強会第5回ご案内について",OpenDate=DateTime.Today.AddDays(-14)},
                new CustomerRequest(){Title="操作中に発生する待機時間について",OpenDate=DateTime.Today.AddDays(-14)}
            };
        }
        public ObservableCollection<CustomerRequest> GetCustomerRequests()
        {
            return _requests;
        }
    }
}
