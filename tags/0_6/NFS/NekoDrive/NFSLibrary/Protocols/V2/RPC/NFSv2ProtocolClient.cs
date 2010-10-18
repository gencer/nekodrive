/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

using System.Net;

/**
 * The class <code>NFSv2ProtocolClient</code> implements the client stub proxy
 * for the NFS_PROGRAM remote program. It provides method stubs
 * which, when called, in turn call the appropriate remote method (procedure).
 */
public class NFSv2ProtocolClient : OncRpcClientStub {

    /**
     * Constructs a <code>NFSv2ProtocolClient</code> client stub proxy object
     * from which the NFS_PROGRAM remote program can be accessed.
     * @param host Internet address of host where to contact the remote program.
     * @param protocol {@link org.acplt.oncrpc.OncRpcProtocols Protocol} to be
     *   used for ONC/RPC calls.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public NFSv2ProtocolClient(IPAddress host, int protocol) :         base(host, NFSv2Protocol.NFS_PROGRAM, 2, 0, protocol) {
    }

    /**
     * Constructs a <code>NFSv2ProtocolClient</code> client stub proxy object
     * from which the NFS_PROGRAM remote program can be accessed.
     * @param host Internet address of host where to contact the remote program.
     * @param port Port number at host where the remote program can be reached.
     * @param protocol {@link org.acplt.oncrpc.OncRpcProtocols Protocol} to be
     *   used for ONC/RPC calls.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public NFSv2ProtocolClient(IPAddress host, int port, int protocol) :        base(host, NFSv2Protocol.NFS_PROGRAM, 2, port, protocol) {
    }

    /**
     * Constructs a <code>NFSv2ProtocolClient</code> client stub proxy object
     * from which the NFS_PROGRAM remote program can be accessed.
     * @param client ONC/RPC client connection object implementing a particular
     *   protocol.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public NFSv2ProtocolClient(OncRpcClient client) : base(client) {
    }

    /**
     * Constructs a <code>NFSv2ProtocolClient</code> client stub proxy object
     * from which the NFS_PROGRAM remote program can be accessed.
     * @param host Internet address of host where to contact the remote program.
     * @param program Remote program number.
     * @param version Remote program version number.
     * @param protocol {@link org.acplt.oncrpc.OncRpcProtocols Protocol} to be
     *   used for ONC/RPC calls.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public NFSv2ProtocolClient(IPAddress host, int program, int version, int protocol) :        base(host, program, version, 0, protocol) {
    }

    /**
     * Constructs a <code>NFSv2ProtocolClient</code> client stub proxy object
     * from which the NFS_PROGRAM remote program can be accessed.
     * @param host Internet address of host where to contact the remote program.
     * @param program Remote program number.
     * @param version Remote program version number.
     * @param port Port number at host where the remote program can be reached.
     * @param protocol {@link org.acplt.oncrpc.OncRpcProtocols Protocol} to be
     *   used for ONC/RPC calls.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public NFSv2ProtocolClient(IPAddress host, int program, int version, int port, int protocol) :        base(host, program, version, port, protocol) {
    }

    /**
     * Call remote procedure NFSPROC_NULL_2.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public void NFSPROC_NULL_2() {
        XdrVoid args_ = XdrVoid.XDR_VOID;
        XdrVoid result_ = XdrVoid.XDR_VOID;
        client.call(NFSv2Protocol.NFSPROC_NULL_2, NFSv2Protocol.NFS_VERSION, args_, result_);
    }

    /**
     * Call remote procedure NFSPROC_GETATTR_2.
     * @param arg1 parameter (of type nfshandle) to the remote procedure call.
     * @return Result from remote procedure call (of type attrstat).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public attrstat NFSPROC_GETATTR_2(nfshandle arg1) {
        attrstat result_ = new attrstat();
        client.call(NFSv2Protocol.NFSPROC_GETATTR_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_;
    }

    /**
     * Call remote procedure NFSPROC_SETATTR_2.
     * @param arg1 parameter (of type sattrargs) to the remote procedure call.
     * @return Result from remote procedure call (of type attrstat).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public attrstat NFSPROC_SETATTR_2(sattrargs arg1) {
        attrstat result_ = new attrstat();
        client.call(NFSv2Protocol.NFSPROC_SETATTR_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_;
    }

    /**
     * Call remote procedure NFSPROC_ROOT_2.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public void NFSPROC_ROOT_2() {
        XdrVoid args_ = XdrVoid.XDR_VOID;
        XdrVoid result_ = XdrVoid.XDR_VOID;
        client.call(NFSv2Protocol.NFSPROC_ROOT_2, NFSv2Protocol.NFS_VERSION, args_, result_);
    }

    /**
     * Call remote procedure NFSPROC_LOOKUP_2.
     * @param arg1 parameter (of type diropargs) to the remote procedure call.
     * @return Result from remote procedure call (of type diropres).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public diropres NFSPROC_LOOKUP_2(diropargs arg1) {
        diropres result_ = new diropres();
        client.call(NFSv2Protocol.NFSPROC_LOOKUP_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_;
    }

    /**
     * Call remote procedure NFSPROC_READLINK_2.
     * @param arg1 parameter (of type nfshandle) to the remote procedure call.
     * @return Result from remote procedure call (of type readlinkres).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public readlinkres NFSPROC_READLINK_2(nfshandle arg1) {
        readlinkres result_ = new readlinkres();
        client.call(NFSv2Protocol.NFSPROC_READLINK_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_;
    }

    /**
     * Call remote procedure NFSPROC_READ_2.
     * @param arg1 parameter (of type readargs) to the remote procedure call.
     * @return Result from remote procedure call (of type readres).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public readres NFSPROC_READ_2(readargs arg1) {
        readres result_ = new readres();
        client.call(NFSv2Protocol.NFSPROC_READ_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_;
    }

    /**
     * Call remote procedure NFSPROC_WRITECACHE_2.
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public void NFSPROC_WRITECACHE_2() {
        XdrVoid args_ = XdrVoid.XDR_VOID;
        XdrVoid result_ = XdrVoid.XDR_VOID;
        client.call(NFSv2Protocol.NFSPROC_WRITECACHE_2, NFSv2Protocol.NFS_VERSION, args_, result_);
    }

    /**
     * Call remote procedure NFSPROC_WRITE_2.
     * @param arg1 parameter (of type writeargs) to the remote procedure call.
     * @return Result from remote procedure call (of type attrstat).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public attrstat NFSPROC_WRITE_2(writeargs arg1) {
        attrstat result_ = new attrstat();
        client.call(NFSv2Protocol.NFSPROC_WRITE_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_;
    }

    /**
     * Call remote procedure NFSPROC_CREATE_2.
     * @param arg1 parameter (of type createargs) to the remote procedure call.
     * @return Result from remote procedure call (of type diropres).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public diropres NFSPROC_CREATE_2(createargs arg1) {
        diropres result_ = new diropres();
        client.call(NFSv2Protocol.NFSPROC_CREATE_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_;
    }

    /**
     * Call remote procedure NFSPROC_REMOVE_2.
     * @param arg1 parameter (of type diropargs) to the remote procedure call.
     * @return Result from remote procedure call (of type nfsstat).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public int NFSPROC_REMOVE_2(diropargs arg1) {
        XdrInt result_ = new XdrInt();
        client.call(NFSv2Protocol.NFSPROC_REMOVE_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_.intValue();
    }

    /**
     * Call remote procedure NFSPROC_RENAME_2.
     * @param arg1 parameter (of type renameargs) to the remote procedure call.
     * @return Result from remote procedure call (of type nfsstat).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public int NFSPROC_RENAME_2(renameargs arg1) {
        XdrInt result_ = new XdrInt();
        client.call(NFSv2Protocol.NFSPROC_RENAME_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_.intValue();
    }

    /**
     * Call remote procedure NFSPROC_LINK_2.
     * @param arg1 parameter (of type linkargs) to the remote procedure call.
     * @return Result from remote procedure call (of type nfsstat).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public int NFSPROC_LINK_2(linkargs arg1) {
        XdrInt result_ = new XdrInt();
        client.call(NFSv2Protocol.NFSPROC_LINK_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_.intValue();
    }

    /**
     * Call remote procedure NFSPROC_SYMLINK_2.
     * @param arg1 parameter (of type symlinkargs) to the remote procedure call.
     * @return Result from remote procedure call (of type nfsstat).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public int NFSPROC_SYMLINK_2(symlinkargs arg1) {
        XdrInt result_ = new XdrInt();
        client.call(NFSv2Protocol.NFSPROC_SYMLINK_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_.intValue();
    }

    /**
     * Call remote procedure NFSPROC_MKDIR_2.
     * @param arg1 parameter (of type createargs) to the remote procedure call.
     * @return Result from remote procedure call (of type diropres).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public diropres NFSPROC_MKDIR_2(createargs arg1) {
        diropres result_ = new diropres();
        client.call(NFSv2Protocol.NFSPROC_MKDIR_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_;
    }

    /**
     * Call remote procedure NFSPROC_RMDIR_2.
     * @param arg1 parameter (of type diropargs) to the remote procedure call.
     * @return Result from remote procedure call (of type nfsstat).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public int NFSPROC_RMDIR_2(diropargs arg1) {
        XdrInt result_ = new XdrInt();
        client.call(NFSv2Protocol.NFSPROC_RMDIR_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_.intValue();
    }

    /**
     * Call remote procedure NFSPROC_READDIR_2.
     * @param arg1 parameter (of type readdirargs) to the remote procedure call.
     * @return Result from remote procedure call (of type readdirres).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public readdirres NFSPROC_READDIR_2(readdirargs arg1) {
        readdirres result_ = new readdirres();
        client.call(NFSv2Protocol.NFSPROC_READDIR_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_;
    }

    /**
     * Call remote procedure NFSPROC_STATFS_2.
     * @param arg1 parameter (of type nfshandle) to the remote procedure call.
     * @return Result from remote procedure call (of type statfsres).
     * @throws OncRpcException if an ONC/RPC error occurs.
     * @throws IOException if an I/O error occurs.
     */
    public statfsres NFSPROC_STATFS_2(nfshandle arg1) {
        statfsres result_ = new statfsres();
        client.call(NFSv2Protocol.NFSPROC_STATFS_2, NFSv2Protocol.NFS_VERSION, arg1, result_);
        return result_;
    }

}
// End of NFSv2ProtocolClient.cs
