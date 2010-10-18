/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class SYMLINK3resok : XdrAble {
    public post_op_fh3 obj;
    public post_op_attr obj_attributes;
    public wcc_data dir_wcc;

    public SYMLINK3resok() {
    }

    public SYMLINK3resok(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        obj.xdrEncode(xdr);
        obj_attributes.xdrEncode(xdr);
        dir_wcc.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        obj = new post_op_fh3(xdr);
        obj_attributes = new post_op_attr(xdr);
        dir_wcc = new wcc_data(xdr);
    }

}
// End of SYMLINK3resok.cs
