/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using NFSLibrary.Protocols.Commons;
using org.acplt.oncrpc;

namespace NFSLibrary.Protocols.V3.RPC
{
    public class SymlinkAccessOK : XdrAble
    {
        private NFSHandle _obj;
        private PostOperationAttributes _obj_attributes;
        private WritingData _dir_wcc;

        public SymlinkAccessOK()
        { }

        public SymlinkAccessOK(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        {
            this._obj.xdrEncode(xdr);
            this._obj_attributes.xdrEncode(xdr);
            this._dir_wcc.xdrEncode(xdr);
        }

        public void xdrDecode(XdrDecodingStream xdr)
        {
            this._obj = new NFSHandle();
            this._obj.Version = V3.RPC.NFSv3Protocol.NFS_V3;
            this._obj.xdrDecode(xdr);
            this._obj_attributes = new PostOperationAttributes(xdr);
            this._dir_wcc = new WritingData(xdr);
        }

        public NFSHandle Handle
        {
            get
            { return this._obj; }
        }

        public PostOperationAttributes Attributes
        {
            get
            { return this._obj_attributes; }
        }

        public WritingData Data
        {
            get
            { return this._dir_wcc; }
        }
    }

    public class SymlinkAccessFAIL : XdrAble
    {
        private WritingData _dir_wcc;

        public SymlinkAccessFAIL()
        { }

        public SymlinkAccessFAIL(XdrDecodingStream xdr)
        { xdrDecode(xdr); }

        public void xdrEncode(XdrEncodingStream xdr)
        { this._dir_wcc.xdrEncode(xdr); }

        public void xdrDecode(XdrDecodingStream xdr)
        { this._dir_wcc = new WritingData(xdr); }

        public WritingData Data
        {
            get
            { return this._dir_wcc; }
        }
    }
    // End of SYMLINK3res.cs
}