/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using NFSLibrary.Protocols.Commons;
using org.acplt.oncrpc;
using System.Net;

/**
 * The class <code>NFSv3MountProtocolClient</code> implements the client stub proxy
 * for the MOUNT_PROGRAM remote program. It provides method stubs
 * which, when called, in turn call the appropriate remote method (procedure).
 */
namespace NFSLibrary.Protocols.V3.RPC.Mount
{
    public class NFSv3MountProtocolClient : OncRpcClientStub
    {

        /**
         * Constructs a <code>NFSv3MountProtocolClient</code> client stub proxy object
         * from which the MOUNT_PROGRAM remote program can be accessed.
         * @param host Internet address of host where to contact the remote program.
         * @param protocol {@link org.acplt.oncrpc.OncRpcProtocols Protocol} to be
         *   used for ONC/RPC calls.
         * @throws OncRpcException if an ONC/RPC error occurs.
         * @throws IOException if an I/O error occurs.
         */
        public NFSv3MountProtocolClient(IPAddress host, int protocol)
            : base(host, NFSv3MountProtocol.MOUNTPROG, 3, 0, protocol, true)
        {
        }

        public NFSv3MountProtocolClient(IPAddress host, int protocol, bool useSecurePort)
            : base(host, NFSv3MountProtocol.MOUNTPROG, 3, 0, protocol, useSecurePort)
        {
        }

        /**
         * Constructs a <code>NFSv3MountProtocolClient</code> client stub proxy object
         * from which the MOUNT_PROGRAM remote program can be accessed.
         * @param host Internet address of host where to contact the remote program.
         * @param port Port number at host where the remote program can be reached.
         * @param protocol {@link org.acplt.oncrpc.OncRpcProtocols Protocol} to be
         *   used for ONC/RPC calls.
         * @throws OncRpcException if an ONC/RPC error occurs.
         * @throws IOException if an I/O error occurs.
         */
        public NFSv3MountProtocolClient(IPAddress host, int port, int protocol)
            : base(host, NFSv3MountProtocol.MOUNTPROG, 3, port, protocol, true)
        {
        }

        /**
         * Constructs a <code>NFSv3MountProtocolClient</code> client stub proxy object
         * from which the MOUNT_PROGRAM remote program can be accessed.
         * @param client ONC/RPC client connection object implementing a particular
         *   protocol.
         * @throws OncRpcException if an ONC/RPC error occurs.
         * @throws IOException if an I/O error occurs.
         */
        public NFSv3MountProtocolClient(OncRpcClient client)
            : base(client)
        {
        }

        /**
         * Constructs a <code>NFSv3MountProtocolClient</code> client stub proxy object
         * from which the MOUNT_PROGRAM remote program can be accessed.
         * @param host Internet address of host where to contact the remote program.
         * @param program Remote program number.
         * @param version Remote program version number.
         * @param protocol {@link org.acplt.oncrpc.OncRpcProtocols Protocol} to be
         *   used for ONC/RPC calls.
         * @throws OncRpcException if an ONC/RPC error occurs.
         * @throws IOException if an I/O error occurs.
         */
        public NFSv3MountProtocolClient(IPAddress host, int program, int version, int protocol)
            : base(host, program, version, 0, protocol, true)
        {
        }

        /**
         * Constructs a <code>NFSv3MountProtocolClient</code> client stub proxy object
         * from which the MOUNT_PROGRAM remote program can be accessed.
         * @param host Internet address of host where to contact the remote program.
         * @param program Remote program number.
         * @param version Remote program version number.
         * @param port Port number at host where the remote program can be reached.
         * @param protocol {@link org.acplt.oncrpc.OncRpcProtocols Protocol} to be
         *   used for ONC/RPC calls.
         * @throws OncRpcException if an ONC/RPC error occurs.
         * @throws IOException if an I/O error occurs.
         */
        public NFSv3MountProtocolClient(IPAddress host, int program, int version, int port, int protocol)
            : base(host, program, version, port, protocol, true)
        {
        }

        public NFSv3MountProtocolClient(IPAddress host, int program, int version, int port, int protocol, bool useSecurePort)
            : base(host, program, version, port, protocol, useSecurePort)
        {
        }

        /**
         * Call remote procedure MOUNTPROC3_NULL_3.
         * @throws OncRpcException if an ONC/RPC error occurs.
         * @throws IOException if an I/O error occurs.
         */
        public void MOUNTPROC3_NULL()
        {
            XdrVoid args_ = XdrVoid.XDR_VOID;
            XdrVoid result_ = XdrVoid.XDR_VOID;
            client.call(NFSv3MountProtocol.MOUNTPROC3_NULL, NFSv3MountProtocol.MOUNTVERS, args_, result_);
        }

        /**
         * Call remote procedure MOUNTPROC3_MNT_3.
         * @param arg1 parameter (of type dirpath) to the remote procedure call.
         * @return Result from remote procedure call (of type mountres3).
         * @throws OncRpcException if an ONC/RPC error occurs.
         * @throws IOException if an I/O error occurs.
         */
        public MountStatus MOUNTPROC3_MNT(Name arg1)
        {
            MountStatus result_ = new MountStatus();

            client.call(NFSv3MountProtocol.MOUNTPROC3_MNT, NFSv3MountProtocol.MOUNTVERS, arg1, result_);

            return result_;
        }

        /**
         * Call remote procedure MOUNTPROC3_DUMP_3.
         * @return Result from remote procedure call (of type mountlist3).
         * @throws OncRpcException if an ONC/RPC error occurs.
         * @throws IOException if an I/O error occurs.
         */
        public MountList MOUNTPROC3_DUMP()
        {
            XdrVoid args_ = XdrVoid.XDR_VOID;
            MountList result_ = new MountList();

            client.call(NFSv3MountProtocol.MOUNTPROC3_DUMP, NFSv3MountProtocol.MOUNTVERS, args_, result_);

            return result_;
        }

        /**
         * Call remote procedure MOUNTPROC3_UMNT_3.
         * @param arg1 parameter (of type dirpath) to the remote procedure call.
         * @throws OncRpcException if an ONC/RPC error occurs.
         * @throws IOException if an I/O error occurs.
         */
        public void MOUNTPROC3_UMNT(Name arg1)
        {
            XdrVoid result_ = XdrVoid.XDR_VOID;

            client.call(NFSv3MountProtocol.MOUNTPROC3_UMNT, NFSv3MountProtocol.MOUNTVERS, arg1, result_);
        }

        /**
         * Call remote procedure MOUNTPROC3_UMNTALL_3.
         * @throws OncRpcException if an ONC/RPC error occurs.
         * @throws IOException if an I/O error occurs.
         */
        public void MOUNTPROC3_UMNTALL()
        {
            XdrVoid args_ = XdrVoid.XDR_VOID;
            XdrVoid result_ = XdrVoid.XDR_VOID;

            client.call(NFSv3MountProtocol.MOUNTPROC3_UMNTALL, NFSv3MountProtocol.MOUNTVERS, args_, result_);
        }

        /**
         * Call remote procedure MOUNTPROC3_EXPORT_3.
         * @return Result from remote procedure call (of type exports3).
         * @throws OncRpcException if an ONC/RPC error occurs.
         * @throws IOException if an I/O error occurs.
         */
        public Exports MOUNTPROC3_EXPORT()
        {
            XdrVoid args_ = XdrVoid.XDR_VOID;
            Exports result_ = new Exports();

            client.call(NFSv3MountProtocol.MOUNTPROC3_EXPORT, NFSv3MountProtocol.MOUNTVERS, args_, result_);

            return result_;
        }

    }
    // End of NFSv3MountProtocolClient.cs
}