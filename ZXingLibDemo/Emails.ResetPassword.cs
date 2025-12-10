using System.Web;
using OutSystems.Application.Abstractions.Emails;
using OutSystems.Application.Emails;
using OutSystems.Application.Core.Email;
using OutSystems.Application.Models.Emails;
using OutSystems.ObjectKeys;
using IterativeTemplateData = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using TemplateData = System.Collections.Generic.Dictionary<string, object>;

namespace ssZXingLibDemo.Flows.FlowEmails {

    public class Emails_ResetPassword : EmailScreen {

        public Emails_ResetPassword(
            ISettingsProvider settingsProvider,
            IApplicationLogger applicationLogger,
            ICssFlatteningService cssFlatteningService) : base(settingsProvider, applicationLogger, cssFlatteningService) { }

        private static string inlineCss;

        

        private static string _template;
        internal virtual string Template {
            get { return _template ?? (_template = GetTemplateContent("Emails.ResetPassword.html.resources")); }
        }

        protected static readonly IEnumerable<string> CssFiles = new List<string> {
"css/ZXingLibDemo.EmailTheme.css",
"css/ZXingLibDemo.Emails.ResetPassword.css",
"css/ZXingLibDemo.EmailTheme.extra.css",

        };

        public async Task<string> GetEmailContentAsync(IRequestContext requestContext, string inParamApplicationName,string inParamCustomerName,string inParamCustomerEmail,string inParamVerificationCode, CancellationToken cancellationToken) {
            if (string.IsNullOrEmpty(inlineCss)) {
                inlineCss = await GetInlineStyleSheetIncludeAsync(CssFiles, cancellationToken);
            }
            binaryImages = new Dictionary<string, Image>();
            var expressions = new TemplateData();

            expressions.Add("KOoBqdLmVF0yD5Ye2ebNzPg_Subject", HtmlEncode(("Password Reset for "+inParamApplicationName).ToString()));
            expressions.Add("STYLE", inlineCss);
            expressions.Add("v5_Style", MergeStyles("text-align: left;"));
            expressions.Add("v19_Style", MergeStyles("margin-left: 0px"));
            expressions.Add("KK9RrRx_0oUu1_1CNbqHs2Q_HREF", HtmlAttributeEncode((DomainNameForLinks + "/ZXingLibDemo/img/ZXingLibDemo.Logo.png").ToString()));
            expressions.Add("KXOIsqQp0X0W5PhByNWVx7Q_Value", HtmlEncode(inParamApplicationName.ToString()));
            expressions.Add("KtpFH71aPfEqxzXf3QfiL1A_", (inParamCustomerName!=""));
            expressions.Add("Kl1dD2da_50ih2AMhtgvqyg_Value", HtmlEncode((("Hi "+inParamCustomerName)+"!").ToString()));
            expressions.Add("KiCwb3Shl0Ey1F8lgXrGgmg_Value", HtmlEncode(inParamVerificationCode.ToString()));
            expressions.Add("KLgs98EhqvU6Lo_lWl9UXhg_HREF", HtmlAttributeEncode((DomainNameForLinks + "/ZXingLibDemo/RecoverPasswordReset"+"?" + "Email=" + HttpUtility.UrlEncode(inParamCustomerEmail.ToString())+"&"+"VerificationCode=" + HttpUtility.UrlEncode((inParamVerificationCode).ToString().ToString())).ToString()));
            expressions.Add("KtztJreH_xUSHwQ2riuX2Lw_Value", HtmlEncode(BuiltInFunction.Year (BuiltInFunction.CurrDate ()).ToString()));
            expressions.Add("KQ5YEFJzPJUSjR_63yRrTbg_Value", HtmlEncode(inParamApplicationName.ToString()));


            return Render(Template, expressions);
        }

        internal void Iterate(IOSList list, Action action) {
            list.StartIteration();
            try {
                while (!list.Eof) {
                    action();
                    list.Advance();
                }
            }
            finally {
                list.EndIteration();
            }
        }
    }
}
