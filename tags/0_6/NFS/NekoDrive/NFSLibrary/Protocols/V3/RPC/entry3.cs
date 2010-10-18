/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class entry3 : XdrAble {
    public fileid3 fileid;
    public filename3 name;
    public cookie3 cookie;
    public entry3 nextentry;

    public entry3() {
    }

    public entry3(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        entry3 _this = this;
        do {
            _this.fileid.xdrEncode(xdr);
            _this.name.xdrEncode(xdr);
            _this.cookie.xdrEncode(xdr);
            _this = _this.nextentry;
            xdr.xdrEncodeBoolean(_this != null);
        } while ( _this != null );
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        entry3 _this = this;
        entry3 _next;
        do {
            _this.fileid = new fileid3(xdr);
            _this.name = new filename3(xdr);
            _this.cookie = new cookie3(xdr);
            _next = xdr.xdrDecodeBoolean() ? new entry3() : null;
            _this.nextentry = _next;
            _this = _next;
        } while ( _this != null );
    }

}
// End of entry3.cs
