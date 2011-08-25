// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
    {
        public class DerivativeSecurityListRequest : Message
        {
            public DerivativeSecurityListRequest() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("z"));
            }

            public DerivativeSecurityListRequest(
                    QuickFix.Fields.SecurityReqID aSecurityReqID,
                    QuickFix.Fields.SecurityListRequestType aSecurityListRequestType,
                    QuickFix.Fields.UnderlyingSymbol aUnderlyingSymbol
                ) : this()
            {
                this.securityReqID = aSecurityReqID;
                this.securityListRequestType = aSecurityListRequestType;
                this.underlyingSymbol = aUnderlyingSymbol;
            }

            public QuickFix.Fields.SecurityReqID securityReqID
            { 
                get 
                {
                    QuickFix.Fields.SecurityReqID val = new QuickFix.Fields.SecurityReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityReqID val) 
            { 
                this.securityReqID = val;
            }
            
            public QuickFix.Fields.SecurityReqID get(QuickFix.Fields.SecurityReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityReqID val) 
            { 
                return isSetSecurityReqID();
            }
            
            public bool isSetSecurityReqID() 
            { 
                return isSetField(Tags.SecurityReqID);
            }
            public QuickFix.Fields.SecurityListRequestType securityListRequestType
            { 
                get 
                {
                    QuickFix.Fields.SecurityListRequestType val = new QuickFix.Fields.SecurityListRequestType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityListRequestType val) 
            { 
                this.securityListRequestType = val;
            }
            
            public QuickFix.Fields.SecurityListRequestType get(QuickFix.Fields.SecurityListRequestType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityListRequestType val) 
            { 
                return isSetSecurityListRequestType();
            }
            
            public bool isSetSecurityListRequestType() 
            { 
                return isSetField(Tags.SecurityListRequestType);
            }
            public QuickFix.Fields.UnderlyingSymbol underlyingSymbol
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSymbol val = new QuickFix.Fields.UnderlyingSymbol();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                this.underlyingSymbol = val;
            }
            
            public QuickFix.Fields.UnderlyingSymbol get(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                return isSetUnderlyingSymbol();
            }
            
            public bool isSetUnderlyingSymbol() 
            { 
                return isSetField(Tags.UnderlyingSymbol);
            }
            public QuickFix.Fields.UnderlyingSymbolSfx underlyingSymbolSfx
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSymbolSfx val = new QuickFix.Fields.UnderlyingSymbolSfx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                this.underlyingSymbolSfx = val;
            }
            
            public QuickFix.Fields.UnderlyingSymbolSfx get(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                return isSetUnderlyingSymbolSfx();
            }
            
            public bool isSetUnderlyingSymbolSfx() 
            { 
                return isSetField(Tags.UnderlyingSymbolSfx);
            }
            public QuickFix.Fields.UnderlyingSecurityID underlyingSecurityID
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityID val = new QuickFix.Fields.UnderlyingSecurityID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                this.underlyingSecurityID = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityID get(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                return isSetUnderlyingSecurityID();
            }
            
            public bool isSetUnderlyingSecurityID() 
            { 
                return isSetField(Tags.UnderlyingSecurityID);
            }
            public QuickFix.Fields.UnderlyingSecurityIDSource underlyingSecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityIDSource val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                this.underlyingSecurityIDSource = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityIDSource get(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                return isSetUnderlyingSecurityIDSource();
            }
            
            public bool isSetUnderlyingSecurityIDSource() 
            { 
                return isSetField(Tags.UnderlyingSecurityIDSource);
            }
            public QuickFix.Fields.NoUnderlyingSecurityAltID noUnderlyingSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoUnderlyingSecurityAltID val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                this.noUnderlyingSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoUnderlyingSecurityAltID get(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                return isSetNoUnderlyingSecurityAltID();
            }
            
            public bool isSetNoUnderlyingSecurityAltID() 
            { 
                return isSetField(Tags.NoUnderlyingSecurityAltID);
            }
            public QuickFix.Fields.UnderlyingProduct underlyingProduct
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingProduct val = new QuickFix.Fields.UnderlyingProduct();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingProduct val) 
            { 
                this.underlyingProduct = val;
            }
            
            public QuickFix.Fields.UnderlyingProduct get(QuickFix.Fields.UnderlyingProduct val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingProduct val) 
            { 
                return isSetUnderlyingProduct();
            }
            
            public bool isSetUnderlyingProduct() 
            { 
                return isSetField(Tags.UnderlyingProduct);
            }
            public QuickFix.Fields.UnderlyingCFICode underlyingCFICode
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCFICode val = new QuickFix.Fields.UnderlyingCFICode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                this.underlyingCFICode = val;
            }
            
            public QuickFix.Fields.UnderlyingCFICode get(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                return isSetUnderlyingCFICode();
            }
            
            public bool isSetUnderlyingCFICode() 
            { 
                return isSetField(Tags.UnderlyingCFICode);
            }
            public QuickFix.Fields.UnderlyingSecurityType underlyingSecurityType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityType val = new QuickFix.Fields.UnderlyingSecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                this.underlyingSecurityType = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityType get(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                return isSetUnderlyingSecurityType();
            }
            
            public bool isSetUnderlyingSecurityType() 
            { 
                return isSetField(Tags.UnderlyingSecurityType);
            }
            public QuickFix.Fields.UnderlyingMaturityMonthYear underlyingMaturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingMaturityMonthYear val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                this.underlyingMaturityMonthYear = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityMonthYear get(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                return isSetUnderlyingMaturityMonthYear();
            }
            
            public bool isSetUnderlyingMaturityMonthYear() 
            { 
                return isSetField(Tags.UnderlyingMaturityMonthYear);
            }
            public QuickFix.Fields.UnderlyingMaturityDate underlyingMaturityDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingMaturityDate val = new QuickFix.Fields.UnderlyingMaturityDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                this.underlyingMaturityDate = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityDate get(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                return isSetUnderlyingMaturityDate();
            }
            
            public bool isSetUnderlyingMaturityDate() 
            { 
                return isSetField(Tags.UnderlyingMaturityDate);
            }
            public QuickFix.Fields.UnderlyingCouponPaymentDate underlyingCouponPaymentDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCouponPaymentDate val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                this.underlyingCouponPaymentDate = val;
            }
            
            public QuickFix.Fields.UnderlyingCouponPaymentDate get(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                return isSetUnderlyingCouponPaymentDate();
            }
            
            public bool isSetUnderlyingCouponPaymentDate() 
            { 
                return isSetField(Tags.UnderlyingCouponPaymentDate);
            }
            public QuickFix.Fields.UnderlyingIssueDate underlyingIssueDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingIssueDate val = new QuickFix.Fields.UnderlyingIssueDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                this.underlyingIssueDate = val;
            }
            
            public QuickFix.Fields.UnderlyingIssueDate get(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                return isSetUnderlyingIssueDate();
            }
            
            public bool isSetUnderlyingIssueDate() 
            { 
                return isSetField(Tags.UnderlyingIssueDate);
            }
            public QuickFix.Fields.UnderlyingRepoCollateralSecurityType underlyingRepoCollateralSecurityType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRepoCollateralSecurityType val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                this.underlyingRepoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.UnderlyingRepoCollateralSecurityType get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                return isSetUnderlyingRepoCollateralSecurityType();
            }
            
            public bool isSetUnderlyingRepoCollateralSecurityType() 
            { 
                return isSetField(Tags.UnderlyingRepoCollateralSecurityType);
            }
            public QuickFix.Fields.UnderlyingRepurchaseTerm underlyingRepurchaseTerm
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRepurchaseTerm val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                this.underlyingRepurchaseTerm = val;
            }
            
            public QuickFix.Fields.UnderlyingRepurchaseTerm get(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                return isSetUnderlyingRepurchaseTerm();
            }
            
            public bool isSetUnderlyingRepurchaseTerm() 
            { 
                return isSetField(Tags.UnderlyingRepurchaseTerm);
            }
            public QuickFix.Fields.UnderlyingRepurchaseRate underlyingRepurchaseRate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRepurchaseRate val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                this.underlyingRepurchaseRate = val;
            }
            
            public QuickFix.Fields.UnderlyingRepurchaseRate get(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                return isSetUnderlyingRepurchaseRate();
            }
            
            public bool isSetUnderlyingRepurchaseRate() 
            { 
                return isSetField(Tags.UnderlyingRepurchaseRate);
            }
            public QuickFix.Fields.UnderlyingFactor underlyingFactor
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingFactor val = new QuickFix.Fields.UnderlyingFactor();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingFactor val) 
            { 
                this.underlyingFactor = val;
            }
            
            public QuickFix.Fields.UnderlyingFactor get(QuickFix.Fields.UnderlyingFactor val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingFactor val) 
            { 
                return isSetUnderlyingFactor();
            }
            
            public bool isSetUnderlyingFactor() 
            { 
                return isSetField(Tags.UnderlyingFactor);
            }
            public QuickFix.Fields.UnderlyingCreditRating underlyingCreditRating
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCreditRating val = new QuickFix.Fields.UnderlyingCreditRating();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                this.underlyingCreditRating = val;
            }
            
            public QuickFix.Fields.UnderlyingCreditRating get(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                return isSetUnderlyingCreditRating();
            }
            
            public bool isSetUnderlyingCreditRating() 
            { 
                return isSetField(Tags.UnderlyingCreditRating);
            }
            public QuickFix.Fields.UnderlyingInstrRegistry underlyingInstrRegistry
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingInstrRegistry val = new QuickFix.Fields.UnderlyingInstrRegistry();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                this.underlyingInstrRegistry = val;
            }
            
            public QuickFix.Fields.UnderlyingInstrRegistry get(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                return isSetUnderlyingInstrRegistry();
            }
            
            public bool isSetUnderlyingInstrRegistry() 
            { 
                return isSetField(Tags.UnderlyingInstrRegistry);
            }
            public QuickFix.Fields.UnderlyingCountryOfIssue underlyingCountryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCountryOfIssue val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                this.underlyingCountryOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingCountryOfIssue get(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                return isSetUnderlyingCountryOfIssue();
            }
            
            public bool isSetUnderlyingCountryOfIssue() 
            { 
                return isSetField(Tags.UnderlyingCountryOfIssue);
            }
            public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue underlyingStateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                this.underlyingStateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                return isSetUnderlyingStateOrProvinceOfIssue();
            }
            
            public bool isSetUnderlyingStateOrProvinceOfIssue() 
            { 
                return isSetField(Tags.UnderlyingStateOrProvinceOfIssue);
            }
            public QuickFix.Fields.UnderlyingLocaleOfIssue underlyingLocaleOfIssue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingLocaleOfIssue val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                this.underlyingLocaleOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingLocaleOfIssue get(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                return isSetUnderlyingLocaleOfIssue();
            }
            
            public bool isSetUnderlyingLocaleOfIssue() 
            { 
                return isSetField(Tags.UnderlyingLocaleOfIssue);
            }
            public QuickFix.Fields.UnderlyingRedemptionDate underlyingRedemptionDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRedemptionDate val = new QuickFix.Fields.UnderlyingRedemptionDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                this.underlyingRedemptionDate = val;
            }
            
            public QuickFix.Fields.UnderlyingRedemptionDate get(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                return isSetUnderlyingRedemptionDate();
            }
            
            public bool isSetUnderlyingRedemptionDate() 
            { 
                return isSetField(Tags.UnderlyingRedemptionDate);
            }
            public QuickFix.Fields.UnderlyingPutOrCall underlyingPutOrCall
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPutOrCall val = new QuickFix.Fields.UnderlyingPutOrCall();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                this.underlyingPutOrCall = val;
            }
            
            public QuickFix.Fields.UnderlyingPutOrCall get(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                return isSetUnderlyingPutOrCall();
            }
            
            public bool isSetUnderlyingPutOrCall() 
            { 
                return isSetField(Tags.UnderlyingPutOrCall);
            }
            public QuickFix.Fields.UnderlyingStrikePrice underlyingStrikePrice
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStrikePrice val = new QuickFix.Fields.UnderlyingStrikePrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                this.underlyingStrikePrice = val;
            }
            
            public QuickFix.Fields.UnderlyingStrikePrice get(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                return isSetUnderlyingStrikePrice();
            }
            
            public bool isSetUnderlyingStrikePrice() 
            { 
                return isSetField(Tags.UnderlyingStrikePrice);
            }
            public QuickFix.Fields.UnderlyingOptAttribute underlyingOptAttribute
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingOptAttribute val = new QuickFix.Fields.UnderlyingOptAttribute();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                this.underlyingOptAttribute = val;
            }
            
            public QuickFix.Fields.UnderlyingOptAttribute get(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                return isSetUnderlyingOptAttribute();
            }
            
            public bool isSetUnderlyingOptAttribute() 
            { 
                return isSetField(Tags.UnderlyingOptAttribute);
            }
            public QuickFix.Fields.UnderlyingContractMultiplier underlyingContractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingContractMultiplier val = new QuickFix.Fields.UnderlyingContractMultiplier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                this.underlyingContractMultiplier = val;
            }
            
            public QuickFix.Fields.UnderlyingContractMultiplier get(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                return isSetUnderlyingContractMultiplier();
            }
            
            public bool isSetUnderlyingContractMultiplier() 
            { 
                return isSetField(Tags.UnderlyingContractMultiplier);
            }
            public QuickFix.Fields.UnderlyingCouponRate underlyingCouponRate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCouponRate val = new QuickFix.Fields.UnderlyingCouponRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                this.underlyingCouponRate = val;
            }
            
            public QuickFix.Fields.UnderlyingCouponRate get(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                return isSetUnderlyingCouponRate();
            }
            
            public bool isSetUnderlyingCouponRate() 
            { 
                return isSetField(Tags.UnderlyingCouponRate);
            }
            public QuickFix.Fields.UnderlyingSecurityExchange underlyingSecurityExchange
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityExchange val = new QuickFix.Fields.UnderlyingSecurityExchange();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                this.underlyingSecurityExchange = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityExchange get(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                return isSetUnderlyingSecurityExchange();
            }
            
            public bool isSetUnderlyingSecurityExchange() 
            { 
                return isSetField(Tags.UnderlyingSecurityExchange);
            }
            public QuickFix.Fields.UnderlyingIssuer underlyingIssuer
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingIssuer val = new QuickFix.Fields.UnderlyingIssuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                this.underlyingIssuer = val;
            }
            
            public QuickFix.Fields.UnderlyingIssuer get(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                return isSetUnderlyingIssuer();
            }
            
            public bool isSetUnderlyingIssuer() 
            { 
                return isSetField(Tags.UnderlyingIssuer);
            }
            public QuickFix.Fields.EncodedUnderlyingIssuerLen encodedUnderlyingIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingIssuerLen val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                this.encodedUnderlyingIssuerLen = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingIssuerLen get(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                return isSetEncodedUnderlyingIssuerLen();
            }
            
            public bool isSetEncodedUnderlyingIssuerLen() 
            { 
                return isSetField(Tags.EncodedUnderlyingIssuerLen);
            }
            public QuickFix.Fields.EncodedUnderlyingIssuer encodedUnderlyingIssuer
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingIssuer val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                this.encodedUnderlyingIssuer = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingIssuer get(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                return isSetEncodedUnderlyingIssuer();
            }
            
            public bool isSetEncodedUnderlyingIssuer() 
            { 
                return isSetField(Tags.EncodedUnderlyingIssuer);
            }
            public QuickFix.Fields.UnderlyingSecurityDesc underlyingSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityDesc val = new QuickFix.Fields.UnderlyingSecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                this.underlyingSecurityDesc = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityDesc get(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                return isSetUnderlyingSecurityDesc();
            }
            
            public bool isSetUnderlyingSecurityDesc() 
            { 
                return isSetField(Tags.UnderlyingSecurityDesc);
            }
            public QuickFix.Fields.EncodedUnderlyingSecurityDescLen encodedUnderlyingSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingSecurityDescLen val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                this.encodedUnderlyingSecurityDescLen = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingSecurityDescLen get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                return isSetEncodedUnderlyingSecurityDescLen();
            }
            
            public bool isSetEncodedUnderlyingSecurityDescLen() 
            { 
                return isSetField(Tags.EncodedUnderlyingSecurityDescLen);
            }
            public QuickFix.Fields.EncodedUnderlyingSecurityDesc encodedUnderlyingSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingSecurityDesc val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                this.encodedUnderlyingSecurityDesc = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingSecurityDesc get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                return isSetEncodedUnderlyingSecurityDesc();
            }
            
            public bool isSetEncodedUnderlyingSecurityDesc() 
            { 
                return isSetField(Tags.EncodedUnderlyingSecurityDesc);
            }
            public QuickFix.Fields.Currency currency
            { 
                get 
                {
                    QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Currency val) 
            { 
                this.currency = val;
            }
            
            public QuickFix.Fields.Currency get(QuickFix.Fields.Currency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Currency val) 
            { 
                return isSetCurrency();
            }
            
            public bool isSetCurrency() 
            { 
                return isSetField(Tags.Currency);
            }
            public QuickFix.Fields.Text text
            { 
                get 
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.Text val) 
            { 
                this.text = val;
            }
            
            public QuickFix.Fields.Text get(QuickFix.Fields.Text val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.Text val) 
            { 
                return isSetText();
            }
            
            public bool isSetText() 
            { 
                return isSetField(Tags.Text);
            }
            public QuickFix.Fields.EncodedTextLen encodedTextLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedTextLen val) 
            { 
                this.encodedTextLen = val;
            }
            
            public QuickFix.Fields.EncodedTextLen get(QuickFix.Fields.EncodedTextLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedTextLen val) 
            { 
                return isSetEncodedTextLen();
            }
            
            public bool isSetEncodedTextLen() 
            { 
                return isSetField(Tags.EncodedTextLen);
            }
            public QuickFix.Fields.EncodedText encodedText
            { 
                get 
                {
                    QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedText val) 
            { 
                this.encodedText = val;
            }
            
            public QuickFix.Fields.EncodedText get(QuickFix.Fields.EncodedText val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedText val) 
            { 
                return isSetEncodedText();
            }
            
            public bool isSetEncodedText() 
            { 
                return isSetField(Tags.EncodedText);
            }
            public QuickFix.Fields.TradingSessionID tradingSessionID
            { 
                get 
                {
                    QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradingSessionID val) 
            { 
                this.tradingSessionID = val;
            }
            
            public QuickFix.Fields.TradingSessionID get(QuickFix.Fields.TradingSessionID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradingSessionID val) 
            { 
                return isSetTradingSessionID();
            }
            
            public bool isSetTradingSessionID() 
            { 
                return isSetField(Tags.TradingSessionID);
            }
            public QuickFix.Fields.TradingSessionSubID tradingSessionSubID
            { 
                get 
                {
                    QuickFix.Fields.TradingSessionSubID val = new QuickFix.Fields.TradingSessionSubID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TradingSessionSubID val) 
            { 
                this.tradingSessionSubID = val;
            }
            
            public QuickFix.Fields.TradingSessionSubID get(QuickFix.Fields.TradingSessionSubID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TradingSessionSubID val) 
            { 
                return isSetTradingSessionSubID();
            }
            
            public bool isSetTradingSessionSubID() 
            { 
                return isSetField(Tags.TradingSessionSubID);
            }
            public QuickFix.Fields.SubscriptionRequestType subscriptionRequestType
            { 
                get 
                {
                    QuickFix.Fields.SubscriptionRequestType val = new QuickFix.Fields.SubscriptionRequestType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                this.subscriptionRequestType = val;
            }
            
            public QuickFix.Fields.SubscriptionRequestType get(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                return isSetSubscriptionRequestType();
            }
            
            public bool isSetSubscriptionRequestType() 
            { 
                return isSetField(Tags.SubscriptionRequestType);
            }
            public class NoUnderlyingSecurityAltID : Group
            {
                public NoUnderlyingSecurityAltID() 
                  :base( Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};
                            public QuickFix.Fields.UnderlyingSecurityAltID underlyingSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityAltID val = new QuickFix.Fields.UnderlyingSecurityAltID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    this.underlyingSecurityAltID = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityAltID get(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    return isSetUnderlyingSecurityAltID();
                }
                
                public bool isSetUnderlyingSecurityAltID() 
                { 
                    return isSetField(Tags.UnderlyingSecurityAltID);
                }
                public QuickFix.Fields.UnderlyingSecurityAltIDSource underlyingSecurityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityAltIDSource val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    this.underlyingSecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityAltIDSource get(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    return isSetUnderlyingSecurityAltIDSource();
                }
                
                public bool isSetUnderlyingSecurityAltIDSource() 
                { 
                    return isSetField(Tags.UnderlyingSecurityAltIDSource);
                }
            
            }
        }
    }
}
