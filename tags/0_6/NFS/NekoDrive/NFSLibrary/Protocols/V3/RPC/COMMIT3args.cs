/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class COMMIT3args : XdrAble {
    public nfs_fh3 file;
    public offset3 offset;
    public count3 count;

    public COMMIT3args() {
    }

    public COMMIT3args(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        file.xdrEncode(xdr);
        offset.xdrEncode(xdr);
        count.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        file = new nfs_fh3(xdr);
        offset = new offset3(xdr);
        count = new count3(xdr);
    }

}
// End of COMMIT3args.cs
