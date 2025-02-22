// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

/*=============================================================================
**
**
** Purpose: This exception is thrown when the marshaller encounters a signature
**          that has an invalid MarshalAs CA for a given argument or is not
**          supported.
**
=============================================================================*/

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
    [Serializable]
    [TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public class MarshalDirectiveException : SystemException
    {
        public MarshalDirectiveException()
            : base(SR.Arg_MarshalDirectiveException)
        {
            HResult = HResults.COR_E_MARSHALDIRECTIVE;
        }

        public MarshalDirectiveException(string? message)
            : base(message)
        {
            HResult = HResults.COR_E_MARSHALDIRECTIVE;
        }

        public MarshalDirectiveException(string? message, Exception? inner)
            : base(message, inner)
        {
            HResult = HResults.COR_E_MARSHALDIRECTIVE;
        }

        [Obsolete(Obsoletions.LegacyFormatterImplMessage, DiagnosticId = Obsoletions.LegacyFormatterImplDiagId, UrlFormat = Obsoletions.SharedUrlFormat)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected MarshalDirectiveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
