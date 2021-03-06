﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace RYDEL.modelView.AdminPagos {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AdminPagosBinding", Namespace="http://servicios.montedepiedad.com.mx/NMP/Services/NMPAdminPagosSvc")]
    public partial class AdminPagos : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private HeaderMessage headerMessageField;
        
        private System.Threading.SendOrPostCallback setOperacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback getPartidaOperationCompleted;
        
        private System.Threading.SendOrPostCallback rejectOperacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback getComprobantesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AdminPagos() {
            this.Url = global::RYDEL.modelView.Properties.Settings.Default.modelView_AdminPagos_AdminPagos;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public HeaderMessage headerMessage {
            get {
                return this.headerMessageField;
            }
            set {
                this.headerMessageField = value;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event setOperacionCompletedEventHandler setOperacionCompleted;
        
        /// <remarks/>
        public event getPartidaCompletedEventHandler getPartidaCompleted;
        
        /// <remarks/>
        public event rejectOperacionCompletedEventHandler rejectOperacionCompleted;
        
        /// <remarks/>
        public event getComprobantesCompletedEventHandler getComprobantesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("headerMessage")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("setOperacion", RequestElementName="setOperacionRequest", RequestNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPAdminPagosSvc", ResponseNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPAdminPagosSvc", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("code")]
        public string setOperacion(OperacionPagoType operacion, out string message, out string detail) {
            object[] results = this.Invoke("setOperacion", new object[] {
                        operacion});
            message = ((string)(results[1]));
            detail = ((string)(results[2]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void setOperacionAsync(OperacionPagoType operacion) {
            this.setOperacionAsync(operacion, null);
        }
        
        /// <remarks/>
        public void setOperacionAsync(OperacionPagoType operacion, object userState) {
            if ((this.setOperacionOperationCompleted == null)) {
                this.setOperacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetOperacionOperationCompleted);
            }
            this.InvokeAsync("setOperacion", new object[] {
                        operacion}, this.setOperacionOperationCompleted, userState);
        }
        
        private void OnsetOperacionOperationCompleted(object arg) {
            if ((this.setOperacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setOperacionCompleted(this, new setOperacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("headerMessage")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("getPartida", RequestElementName="getPartidaRequest", RequestNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPAdminPagosSvc", ResponseNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPAdminPagosSvc", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("partidaSaldos")]
        public PartidaSaldosType getPartida(long folio) {
            object[] results = this.Invoke("getPartida", new object[] {
                        folio});
            return ((PartidaSaldosType)(results[0]));
        }
        
        /// <remarks/>
        public void getPartidaAsync(long folio) {
            this.getPartidaAsync(folio, null);
        }
        
        /// <remarks/>
        public void getPartidaAsync(long folio, object userState) {
            if ((this.getPartidaOperationCompleted == null)) {
                this.getPartidaOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPartidaOperationCompleted);
            }
            this.InvokeAsync("getPartida", new object[] {
                        folio}, this.getPartidaOperationCompleted, userState);
        }
        
        private void OngetPartidaOperationCompleted(object arg) {
            if ((this.getPartidaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPartidaCompleted(this, new getPartidaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("headerMessage")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("rejectOperacion", RequestElementName="rejectOperacionRequest", RequestNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPAdminPagosSvc", ResponseNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPAdminPagosSvc", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("code")]
        public string rejectOperacion(OperacionPagoType operacion, out string message, out string detail) {
            object[] results = this.Invoke("rejectOperacion", new object[] {
                        operacion});
            message = ((string)(results[1]));
            detail = ((string)(results[2]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void rejectOperacionAsync(OperacionPagoType operacion) {
            this.rejectOperacionAsync(operacion, null);
        }
        
        /// <remarks/>
        public void rejectOperacionAsync(OperacionPagoType operacion, object userState) {
            if ((this.rejectOperacionOperationCompleted == null)) {
                this.rejectOperacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnrejectOperacionOperationCompleted);
            }
            this.InvokeAsync("rejectOperacion", new object[] {
                        operacion}, this.rejectOperacionOperationCompleted, userState);
        }
        
        private void OnrejectOperacionOperationCompleted(object arg) {
            if ((this.rejectOperacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.rejectOperacionCompleted(this, new rejectOperacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("headerMessage")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("getComprobantes", RequestElementName="getComprobantesRequest", RequestNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPAdminPagosSvc", ResponseNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPAdminPagosSvc", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("comprobantesList")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("file", Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPFileType", IsNullable=false)]
        public FileType[] getComprobantes(long serieImporte) {
            object[] results = this.Invoke("getComprobantes", new object[] {
                        serieImporte});
            return ((FileType[])(results[0]));
        }
        
        /// <remarks/>
        public void getComprobantesAsync(long serieImporte) {
            this.getComprobantesAsync(serieImporte, null);
        }
        
        /// <remarks/>
        public void getComprobantesAsync(long serieImporte, object userState) {
            if ((this.getComprobantesOperationCompleted == null)) {
                this.getComprobantesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetComprobantesOperationCompleted);
            }
            this.InvokeAsync("getComprobantes", new object[] {
                        serieImporte}, this.getComprobantesOperationCompleted, userState);
        }
        
        private void OngetComprobantesOperationCompleted(object arg) {
            if ((this.getComprobantesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getComprobantesCompleted(this, new getComprobantesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HeaderMessageResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPStandardHeader")]
    [System.Xml.Serialization.XmlRootAttribute("headerMessage", Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPStandardHeader", IsNullable=false)]
    public partial class HeaderMessage : System.Web.Services.Protocols.SoapHeader {
        
        private string usuarioField;
        
        private string idConsumidorField;
        
        private string idDestinoField;
        
        /// <remarks/>
        public string usuario {
            get {
                return this.usuarioField;
            }
            set {
                this.usuarioField = value;
            }
        }
        
        /// <remarks/>
        public string idConsumidor {
            get {
                return this.idConsumidorField;
            }
            set {
                this.idConsumidorField = value;
            }
        }
        
        /// <remarks/>
        public string idDestino {
            get {
                return this.idDestinoField;
            }
            set {
                this.idDestinoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPFileType")]
    public partial class FileType {
        
        private long idOperacionField;
        
        private byte[] archivoField;
        
        /// <remarks/>
        public long idOperacion {
            get {
                return this.idOperacionField;
            }
            set {
                this.idOperacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] archivo {
            get {
                return this.archivoField;
            }
            set {
                this.archivoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPPartidaSaldos")]
    public partial class PartidaSaldosType {
        
        private long folioField;
        
        private string tipoContratoField;
        
        private long sucursalField;
        
        private long transaccionField;
        
        private long idClienteField;
        
        private bool aplicarReempenoField;
        
        private bool prestamoPagadoField;
        
        private int numRefrendoField;
        
        private System.DateTime fechaComercializacionField;

				private string estadoPagoField;
        
        private OperacionesBancariasTypeDetalleOperacionBancaria[] operacionesBancariasDisponiblesField;
        
        /// <remarks/>
        public long folio {
            get {
                return this.folioField;
            }
            set {
                this.folioField = value;
            }
        }
        
        /// <remarks/>
        public string tipoContrato {
            get {
                return this.tipoContratoField;
            }
            set {
                this.tipoContratoField = value;
            }
        }
        
        /// <remarks/>
        public long sucursal {
            get {
                return this.sucursalField;
            }
            set {
                this.sucursalField = value;
            }
        }
        
        /// <remarks/>
        public long transaccion {
            get {
                return this.transaccionField;
            }
            set {
                this.transaccionField = value;
            }
        }
        
        /// <remarks/>
        public long idCliente {
            get {
                return this.idClienteField;
            }
            set {
                this.idClienteField = value;
            }
        }
        
        /// <remarks/>
        public bool aplicarReempeno {
            get {
                return this.aplicarReempenoField;
            }
            set {
                this.aplicarReempenoField = value;
            }
        }
        
        /// <remarks/>
        public bool prestamoPagado {
            get {
                return this.prestamoPagadoField;
            }
            set {
                this.prestamoPagadoField = value;
            }
        }
        
        /// <remarks/>
        public int numRefrendo {
            get {
                return this.numRefrendoField;
            }
            set {
                this.numRefrendoField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime fechaComercializacion {
            get {
                return this.fechaComercializacionField;
            }
            set {
                this.fechaComercializacionField = value;
            }
        }

				public string estadoPago
				{
					get { return this.estadoPagoField; }
					set { this.estadoPagoField = value; }
				}
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("detalleOperacionBancaria", IsNullable=false)]
        public OperacionesBancariasTypeDetalleOperacionBancaria[] operacionesBancariasDisponibles {
            get {
                return this.operacionesBancariasDisponiblesField;
            }
            set {
                this.operacionesBancariasDisponiblesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPPartidaSaldos")]
    public partial class OperacionesBancariasTypeDetalleOperacionBancaria {
        
        private long idOperacionField;
        
        private decimal montoMaximoField;
        
        private decimal montoMinimoField;
        
        private string nombreOperacionField;
        
        /// <remarks/>
        public long idOperacion {
            get {
                return this.idOperacionField;
            }
            set {
                this.idOperacionField = value;
            }
        }
        
        /// <remarks/>
        public decimal montoMaximo {
            get {
                return this.montoMaximoField;
            }
            set {
                this.montoMaximoField = value;
            }
        }
        
        /// <remarks/>
        public decimal montoMinimo {
            get {
                return this.montoMinimoField;
            }
            set {
                this.montoMinimoField = value;
            }
        }
        
        /// <remarks/>
        public string nombreOperacion {
            get {
                return this.nombreOperacionField;
            }
            set {
                this.nombreOperacionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPOperacionPago")]
    public partial class OperacionPagoType {
        
        private long folioField;
        
        private long idOperacionField;
        
        private decimal importeField;
        
        private bool importeFieldSpecified;
        
        private long transaccionField;
        
        private long autorizacionField;
        
        private bool autorizacionFieldSpecified;

				private string numeroTarjetaField;
        
        private string transaccionBancariaField;
        
        private string origenField;
        
        /// <remarks/>
        public long folio {
            get {
                return this.folioField;
            }
            set {
                this.folioField = value;
            }
        }
        
        /// <remarks/>
        public long idOperacion {
            get {
                return this.idOperacionField;
            }
            set {
                this.idOperacionField = value;
            }
        }
        
        /// <remarks/>
        public decimal importe {
            get {
                return this.importeField;
            }
            set {
                this.importeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool importeSpecified {
            get {
                return this.importeFieldSpecified;
            }
            set {
                this.importeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public long transaccion {
            get {
                return this.transaccionField;
            }
            set {
                this.transaccionField = value;
            }
        }
        
        /// <remarks/>
        public long autorizacion {
            get {
                return this.autorizacionField;
            }
            set {
                this.autorizacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autorizacionSpecified {
            get {
                return this.autorizacionFieldSpecified;
            }
            set {
                this.autorizacionFieldSpecified = value;
            }
        }

				/// <remarks/>
				public string numeroTarjeta
				{
					get
					{
						return this.numeroTarjetaField;
					}
					set
					{
						this.numeroTarjetaField = value;
					}
				}
        
        /// <remarks/>
        public string transaccionBancaria {
            get {
                return this.transaccionBancariaField;
            }
            set {
                this.transaccionBancariaField = value;
            }
        }
        
        /// <remarks/>
        public string origen {
            get {
                return this.origenField;
            }
            set {
                this.origenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPStandardHeader")]
    public partial class HeaderMessageResponse : HeaderMessage {
        
        private int codigoRespuestaField;
        
        private string descripcionRespuestaField;
        
        /// <remarks/>
        public int codigoRespuesta {
            get {
                return this.codigoRespuestaField;
            }
            set {
                this.codigoRespuestaField = value;
            }
        }
        
        /// <remarks/>
        public string descripcionRespuesta {
            get {
                return this.descripcionRespuestaField;
            }
            set {
                this.descripcionRespuestaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void setOperacionCompletedEventHandler(object sender, setOperacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setOperacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setOperacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string detail {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void getPartidaCompletedEventHandler(object sender, getPartidaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPartidaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPartidaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public PartidaSaldosType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PartidaSaldosType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void rejectOperacionCompletedEventHandler(object sender, rejectOperacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class rejectOperacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal rejectOperacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string detail {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void getComprobantesCompletedEventHandler(object sender, getComprobantesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getComprobantesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getComprobantesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public FileType[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((FileType[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591