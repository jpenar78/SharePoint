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
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace RYDEL.modelView.DSRFPagoLinea {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="DSRFPagoLineaBinding", Namespace="http://servicios.montedepiedad.com.mx/NMP/Services/NMPDSRFPagoLineaSvc")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(preregistroPagoType))]
    public partial class DSRFPagoLinea : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private HeaderMessage headerMessageField;
        
        private System.Threading.SendOrPostCallback getPartidaClienteOperationCompleted;
        
        private System.Threading.SendOrPostCallback notificarPagoOperationCompleted;
        
        private System.Threading.SendOrPostCallback preregistrarPagoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DSRFPagoLinea() {
            this.Url = global::RYDEL.modelView.Properties.Settings.Default.RYDEL_modelView_DSRFPagoLinea_DSRFPagoLinea;
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
        public event getPartidaClienteCompletedEventHandler getPartidaClienteCompleted;
        
        /// <remarks/>
        public event notificarPagoCompletedEventHandler notificarPagoCompleted;
        
        /// <remarks/>
        public event preregistrarPagoCompletedEventHandler preregistrarPagoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("headerMessage")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("getPartidaCliente", RequestElementName="getPartidaClienteRequest", RequestNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPDSRFPagoLineaSvc", ResponseNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPDSRFPagoLineaSvc", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("respuesta")]
        public string getPartidaCliente(long folioPartida, out string nombre, out string apellidoPaterno, out string apellidoMaterno, out string correoElectronico, out PartidaSaldosType partidaSaldos) {
            object[] results = this.Invoke("getPartidaCliente", new object[] {
                        folioPartida});
            nombre = ((string)(results[1]));
            apellidoPaterno = ((string)(results[2]));
            apellidoMaterno = ((string)(results[3]));
            correoElectronico = ((string)(results[4]));
            partidaSaldos = ((PartidaSaldosType)(results[5]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getPartidaClienteAsync(long folioPartida) {
            this.getPartidaClienteAsync(folioPartida, null);
        }
        
        /// <remarks/>
        public void getPartidaClienteAsync(long folioPartida, object userState) {
            if ((this.getPartidaClienteOperationCompleted == null)) {
                this.getPartidaClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPartidaClienteOperationCompleted);
            }
            this.InvokeAsync("getPartidaCliente", new object[] {
                        folioPartida}, this.getPartidaClienteOperationCompleted, userState);
        }
        
        private void OngetPartidaClienteOperationCompleted(object arg) {
            if ((this.getPartidaClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPartidaClienteCompleted(this, new getPartidaClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("headerMessage")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("notificarPago", RequestElementName="notificarPagoRequest", RequestNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPDSRFPagoLineaSvc", ResponseNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPDSRFPagoLineaSvc", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("respuesta")]
        public string notificarPago(OperacionPagoType aplicarMovimiento, string correoElectronico, [System.Xml.Serialization.XmlArrayItemAttribute("file", Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPFileType", IsNullable=false)] out FileType[] comprobantesPDF) {
            object[] results = this.Invoke("notificarPago", new object[] {
                        aplicarMovimiento,
                        correoElectronico});
            comprobantesPDF = ((FileType[])(results[1]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void notificarPagoAsync(OperacionPagoType aplicarMovimiento, string correoElectronico) {
            this.notificarPagoAsync(aplicarMovimiento, correoElectronico, null);
        }
        
        /// <remarks/>
        public void notificarPagoAsync(OperacionPagoType aplicarMovimiento, string correoElectronico, object userState) {
            if ((this.notificarPagoOperationCompleted == null)) {
                this.notificarPagoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnnotificarPagoOperationCompleted);
            }
            this.InvokeAsync("notificarPago", new object[] {
                        aplicarMovimiento,
                        correoElectronico}, this.notificarPagoOperationCompleted, userState);
        }
        
        private void OnnotificarPagoOperationCompleted(object arg) {
            if ((this.notificarPagoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.notificarPagoCompleted(this, new notificarPagoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("headerMessage")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://servicios.montedepiedad.com.mx/NMP/Services/NMPDSRFPagoLineaSvc/preregistr" +
            "arPago", RequestElementName="preregistarPagoRequest", RequestNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPDSRFPagoLineaSvc", ResponseElementName="preregistarPagoResponse", ResponseNamespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPDSRFPagoLineaSvc", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("respuesta")]
        public responseTypeRespuesta preregistrarPago([System.Xml.Serialization.XmlElementAttribute(Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPOperacionPago")] preregistroPagosTypeTransaccionPago transaccionPago) {
            object[] results = this.Invoke("preregistrarPago", new object[] {
                        transaccionPago});
            return ((responseTypeRespuesta)(results[0]));
        }
        
        /// <remarks/>
        public void preregistrarPagoAsync(preregistroPagosTypeTransaccionPago transaccionPago) {
            this.preregistrarPagoAsync(transaccionPago, null);
        }
        
        /// <remarks/>
        public void preregistrarPagoAsync(preregistroPagosTypeTransaccionPago transaccionPago, object userState) {
            if ((this.preregistrarPagoOperationCompleted == null)) {
                this.preregistrarPagoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnpreregistrarPagoOperationCompleted);
            }
            this.InvokeAsync("preregistrarPago", new object[] {
                        transaccionPago}, this.preregistrarPagoOperationCompleted, userState);
        }
        
        private void OnpreregistrarPagoOperationCompleted(object arg) {
            if ((this.preregistrarPagoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.preregistrarPagoCompleted(this, new preregistrarPagoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPOperacionPago")]
    public partial class preregistroPagoType {
        
        private preregistroPagoTypeBanco bancoField;
        
        private preregistroPagoTypeCliente clienteField;
        
        private preregistroPagoTypePartida[] partidasField;
        
        /// <remarks/>
        public preregistroPagoTypeBanco banco {
            get {
                return this.bancoField;
            }
            set {
                this.bancoField = value;
            }
        }
        
        /// <remarks/>
        public preregistroPagoTypeCliente cliente {
            get {
                return this.clienteField;
            }
            set {
                this.clienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("partida", IsNullable=false)]
        public preregistroPagoTypePartida[] partidas {
            get {
                return this.partidasField;
            }
            set {
                this.partidasField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPOperacionPago")]
    public partial class preregistroPagoTypeBanco {
        
        private string transaccionBancariaField;
        
        /// <remarks/>
        public string transaccionBancaria {
            get {
                return this.transaccionBancariaField;
            }
            set {
                this.transaccionBancariaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPOperacionPago")]
    public partial class preregistroPagoTypeCliente {
        
        private string correoElectronicoField;
        
        /// <remarks/>
        public string correoElectronico {
            get {
                return this.correoElectronicoField;
            }
            set {
                this.correoElectronicoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPOperacionPago")]
    public partial class preregistroPagoTypePartida {
        
        private int folioField;
        
        private int idOperacionField;
        
        private decimal montoField;
        
        private string numeroTransaccionField;
        
        private string origenField;
        
        /// <remarks/>
        public int folio {
            get {
                return this.folioField;
            }
            set {
                this.folioField = value;
            }
        }
        
        /// <remarks/>
        public int idOperacion {
            get {
                return this.idOperacionField;
            }
            set {
                this.idOperacionField = value;
            }
        }
        
        /// <remarks/>
        public decimal monto {
            get {
                return this.montoField;
            }
            set {
                this.montoField = value;
            }
        }
        
        /// <remarks/>
        public string numeroTransaccion {
            get {
                return this.numeroTransaccionField;
            }
            set {
                this.numeroTransaccionField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
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
        
        /// <remarks/>
        public string estadoPago {
            get {
                return this.estadoPagoField;
            }
            set {
                this.estadoPagoField = value;
            }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPOperacionPago")]
    public partial class preregistroPagosTypeTransaccionPago : preregistroPagoType {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://servicios.montedepiedad.com.mx/NMP/Schema/NMPDSRFPagoLineaSvc")]
    public partial class responseTypeRespuesta {
        
        private string codigoField;
        
        private string mensajeField;
        
        /// <remarks/>
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        public string mensaje {
            get {
                return this.mensajeField;
            }
            set {
                this.mensajeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void getPartidaClienteCompletedEventHandler(object sender, getPartidaClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPartidaClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPartidaClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        public string nombre {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string apellidoPaterno {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
        
        /// <remarks/>
        public string apellidoMaterno {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[3]));
            }
        }
        
        /// <remarks/>
        public string correoElectronico {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[4]));
            }
        }
        
        /// <remarks/>
        public PartidaSaldosType partidaSaldos {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PartidaSaldosType)(this.results[5]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void notificarPagoCompletedEventHandler(object sender, notificarPagoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class notificarPagoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal notificarPagoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        public FileType[] comprobantesPDF {
            get {
                this.RaiseExceptionIfNecessary();
                return ((FileType[])(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    public delegate void preregistrarPagoCompletedEventHandler(object sender, preregistrarPagoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1087.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class preregistrarPagoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal preregistrarPagoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public responseTypeRespuesta Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((responseTypeRespuesta)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591