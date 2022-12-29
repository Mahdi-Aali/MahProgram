namespace MahProgram.Utilities.Email;

public static class EmailBody
{
    public static string AnswereContactUsBody(string message)
    {
        return @$"
<table width=""100%"" align=""center"" border=""0"" cellspacing=""0"" cellpadding=""0"" mc:repeatable=""Select"" mc:variant=""big image (layout-8/1)"">
  



  
    <!--START LAYOUT 8/1-->
  
    <tbody><tr>
      <td valign=""top"" class=""fix-box"">
        <table width=""100%"" align=""center"" border=""0"" cellspacing=""0"" cellpadding=""0"" class=""full-width"">
  
  
        <tbody><tr>
          <td class=""full-width"" width=""100%"" align=""center"" valign=""top"">
            <!-- start header container -->  
            <table width=""600"" align=""center"" border=""0"" cellspacing=""0"" cellpadding=""0"" class=""full-width"" style=""background-color:#ffffff; "">
  
              <tbody><tr>
                <td valign=""top"" align=""center"" class=""image-100-percent"">
  
                  <a href=""#"">
                    <img mc:edit=""image (layout-8)"" src=""https://camboriu.news/wp-content/uploads/2019/08/curso-tecnologia-1068x580.jpg.webp"" width=""600"" alt=""image_600x190"" style=""max-width:600px; display:block !important; "" border=""0"" hspace=""0"" vspace=""0"">  
                  </a>
                </td>
              </tr>
  
            </tbody></table>
            <!-- end header container --> 
          </td>
        </tr>
      </tbody></table>
    </td>
  </tr>
    <!--END LAYOUT 8/1-->  
  
  
  
  </tbody></table>

<table width=""100%"" align=""center"" border=""0"" cellspacing=""0"" cellpadding=""0"" mc:repeatable=""Select"" mc:variant=""date and month , title and content (layout-8/2)"">


    <!-- START LAYOUT 8/2 --> 
   
    <tbody><tr>
       <td align=""center"" valign=""top"" class=""fix-box"">
   
        <!-- start layout-8/2 container width 600px --> 
        <table width=""600"" align=""center"" border=""0"" cellspacing=""0"" cellpadding=""0"" class=""container"" bgcolor=""#ffffff"" style=""background-color: #ffffff; border-bottom:2px solid #c7c7c7; "">
          <tbody><tr>
            <td valign=""top"">
   
              <!-- start layout-8/2 container width 560px --> 
              <table width=""560"" align=""center"" border=""0"" cellspacing=""0"" cellpadding=""0"" class=""full-width"" bgcolor=""#ffffff"" style=""background-color:#ffffff;"">
   
                <!--start space height --> 
                <tbody><tr>
                  <td height=""20""></td>
                </tr>
                <!--end space height --> 
   
               <!-- start container date and content -->
                <tr>
   
                 <!-- start date content -->
                 <td valign=""top"">
                    <table width=""110"" border=""0"" cellspacing=""0"" cellpadding=""0"" align=""left"" style=""height:110px; border-right:1px solid #bababa;  background-color:#f6f6f6;"">
                       <!--start space height --> 
                      <tbody><tr>
                        <td height=""15""></td>
                      </tr>
                      <!--end space height --> 
                    
                   
   
                       <tr>
                        <td mc:edit=""mounth (layout-8)"" valign=""top"" style=""font-size: 22px; line-height: 22px; font-family: BYekan,'BYekan',tahoma; color:#5eb0f0; font-weight:normal; text-align:center; mso-line-height-rule: exactly;"">
                           <div style=""line-height:100%;"">
                             <singleline>ماه پروگرام</singleline>
                            </div>
                        </td>
                      </tr>
   
                       <!--start space height --> 
                      <tr>
                        <td height=""15""></td>
                      </tr>
                      <!--end space height --> 
   
                    </tbody></table>
                  </td>
                  <!-- end date content -->
   
   
   
                   <!-- start space width -->
                   <td valign=""top"">
                     <table width=""20"" border=""0"" align=""center"" cellpadding=""0"" cellspacing=""0"">
                       <tbody><tr>
                         <td valign=""top"">
                           &nbsp;
                         </td>
                       </tr>
                     </tbody></table>
                   </td>
                   <!--end space width -->
   
   
   
                   <!-- start text content --> 
                  <td valign=""top"">
                    <table border=""0"" cellspacing=""0"" cellpadding=""0"" align=""left"">
                      <tbody><tr>
                        <td mc:edit=""heading (layout-8)"" style=""font-size: 18px; line-height: 22px; font-family: BYekan,'BYekan',tahoma; color:#555555; font-weight:bold; text-align:right; direction:rtl;"">
                          <span style=""color: #555555; font-weight:bold;"">
                            <a href=""#"" style=""text-decoration: none; color: #555555; font-weight: bold;"">
                              پاسخ به تماس شما
                            </a>
                          </span>
                        </td>
                      </tr>
   
                      <!--start space height --> 
                      <tr>
                        <td height=""15""></td>
                      </tr>
                      <!--end space height --> 
   
                      <tr>
                        <td mc:edit=""content (layout-8)"" style=""font-size: 13px; line-height: 22px; font-family: BYekan,'BYekan',tahoma; color:#a3a2a2; font-weight:normal; text-align:right;direction:rtl; "">
                         
                            {message} 
   
                        </td>
                      </tr>
   
                     <!--start space height --> 
                      <tr>
                        <td height=""15""></td>
                      </tr>
                      <!--end space height --> 
   
                     <!-- start button text -->
                     <tr>
                       <td>
                         <table align=""left"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                           <tbody><tr>
                             <td mc:edit=""button (layout-8)"" style=""font-size: 12px; line-height: 18px; font-family: BYekan,'BYekan',tahoma; color:#5eb0f0; font-weight:bold; text-align:center;"">
                                 <span style=""text-decoration: none; color: #5eb0f0;""><a href=""https://mahprogram.com"" style=""text-decoration: none; color: #5eb0f0; "">بازگشت به سایت</a></span>
                             </td>
                           </tr>
                         </tbody></table>
                       </td>
                     </tr>
                     <!-- end button text -->
   
   
                    </tbody></table>
                  </td>
                  <!-- end text content --> 
                </tr>
   
                <!-- end container date and content -->
                
   
                <!--start space height --> 
                <tr>
                  <td height=""20""></td>
                </tr>
                <!--end space height --> 
              </tbody></table>
              <!-- end layout-8/2 container width 560px --> 
            </td>
          </tr>
        </tbody></table>
        <!-- end layout-8/2 container width 600px --> 
      </td>
    </tr>
   
    <!-- END LAYOUT 8/2 --> 
   
   
   
   </tbody></table>
";
    }
}
