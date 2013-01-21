// Copyright (c) 2012, Event Store LLP
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
// 
// Redistributions of source code must retain the above copyright notice,
// this list of conditions and the following disclaimer.
// Redistributions in binary form must reproduce the above copyright
// notice, this list of conditions and the following disclaimer in the
// documentation and/or other materials provided with the distribution.
// Neither the name of the Event Store LLP nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
// 
using System.Collections.Generic;
using System.Text;

namespace EventStore.Core.Services.Transport.Http
{
    public class ResponseConfiguration
    {
        public readonly int Code;
        public readonly string Description;
        public readonly string ContentType;
        private readonly Encoding _encoding;

        public readonly IEnumerable<KeyValuePair<string, string>> Headers;

        public ResponseConfiguration(int code, string description, string contentType, Encoding encoding, params KeyValuePair<string, string>[] headers)
                : this(code, description, contentType, encoding, headers as IEnumerable<KeyValuePair<string, string>>)
        {
        }

        public ResponseConfiguration(int code, string description, string contentType, Encoding encoding, IEnumerable<KeyValuePair<string, string>> headers)
        {
            Code = code;
            Description = description;
            ContentType = contentType;
            _encoding = encoding;
            Headers = headers;
        }

        public Encoding Encoding
        {
            get { return _encoding; }
        }
    }
}