// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class OrderMassCancelReport : Message
        {
            public const string MsgType = "r";

            public OrderMassCancelReport() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("r"));
            }

            public OrderMassCancelReport(
                    QuickFix.Fields.MassCancelRequestType aMassCancelRequestType,
                    QuickFix.Fields.MassCancelResponse aMassCancelResponse
                ) : this()
            {
                this.MassCancelRequestType = aMassCancelRequestType;
                this.MassCancelResponse = aMassCancelResponse;
            }

            public QuickFix.Fields.MassCancelRequestType MassCancelRequestType
            { 
                get 
                {
                    QuickFix.Fields.MassCancelRequestType val = new QuickFix.Fields.MassCancelRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MassCancelRequestType val) 
            { 
                this.MassCancelRequestType = val;
            }
            
            public QuickFix.Fields.MassCancelRequestType Get(QuickFix.Fields.MassCancelRequestType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MassCancelRequestType val) 
            { 
                return IsSetMassCancelRequestType();
            }
            
            public bool IsSetMassCancelRequestType() 
            { 
                return IsSetField(Tags.MassCancelRequestType);
            }
            public QuickFix.Fields.ClOrdID ClOrdID
            { 
                get 
                {
                    QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.ClOrdID val) 
            { 
                this.ClOrdID = val;
            }
            
            public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.ClOrdID val) 
            { 
                return IsSetClOrdID();
            }
            
            public bool IsSetClOrdID() 
            { 
                return IsSetField(Tags.ClOrdID);
            }
            public QuickFix.Fields.MassCancelResponse MassCancelResponse
            { 
                get 
                {
                    QuickFix.Fields.MassCancelResponse val = new QuickFix.Fields.MassCancelResponse();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MassCancelResponse val) 
            { 
                this.MassCancelResponse = val;
            }
            
            public QuickFix.Fields.MassCancelResponse Get(QuickFix.Fields.MassCancelResponse val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MassCancelResponse val) 
            { 
                return IsSetMassCancelResponse();
            }
            
            public bool IsSetMassCancelResponse() 
            { 
                return IsSetField(Tags.MassCancelResponse);
            }
            public QuickFix.Fields.MassCancelRejectReason MassCancelRejectReason
            { 
                get 
                {
                    QuickFix.Fields.MassCancelRejectReason val = new QuickFix.Fields.MassCancelRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MassCancelRejectReason val) 
            { 
                this.MassCancelRejectReason = val;
            }
            
            public QuickFix.Fields.MassCancelRejectReason Get(QuickFix.Fields.MassCancelRejectReason val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MassCancelRejectReason val) 
            { 
                return IsSetMassCancelRejectReason();
            }
            
            public bool IsSetMassCancelRejectReason() 
            { 
                return IsSetField(Tags.MassCancelRejectReason);
            }
        }
    }
}
