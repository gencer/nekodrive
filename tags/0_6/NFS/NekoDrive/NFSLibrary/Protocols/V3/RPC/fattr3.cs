/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class fattr3 : XdrAble {
    public int type;
    public mode3 mode;
    public uint32 nlink;
    public uid3 uid;
    public gid3 gid;
    public size3 size;
    public size3 used;
    public specdata3 rdev;
    public uint64 fsid;
    public fileid3 fileid;
    public nfstime3 atime;
    public nfstime3 mtime;
    public nfstime3 ctime;

    public fattr3() {
    }

    public fattr3(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeInt(type);
        mode.xdrEncode(xdr);
        nlink.xdrEncode(xdr);
        uid.xdrEncode(xdr);
        gid.xdrEncode(xdr);
        size.xdrEncode(xdr);
        used.xdrEncode(xdr);
        rdev.xdrEncode(xdr);
        fsid.xdrEncode(xdr);
        fileid.xdrEncode(xdr);
        atime.xdrEncode(xdr);
        mtime.xdrEncode(xdr);
        ctime.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        type = xdr.xdrDecodeInt();
        mode = new mode3(xdr);
        nlink = new uint32(xdr);
        uid = new uid3(xdr);
        gid = new gid3(xdr);
        size = new size3(xdr);
        used = new size3(xdr);
        rdev = new specdata3(xdr);
        fsid = new uint64(xdr);
        fileid = new fileid3(xdr);
        atime = new nfstime3(xdr);
        mtime = new nfstime3(xdr);
        ctime = new nfstime3(xdr);
    }

}
// End of fattr3.cs
