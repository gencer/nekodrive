/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class READLINK3args : XdrAble {
    public nfs_fh3 symlink;

    public READLINK3args() {
    }

    public READLINK3args(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        symlink.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        symlink = new nfs_fh3(xdr);
    }

}
// End of READLINK3args.cs
