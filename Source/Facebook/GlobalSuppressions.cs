//-----------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="The Outercurve Foundation">
//    Copyright (c) 2011, The Outercurve Foundation.
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//      http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
// <author>Nathan Totten (ntotten.com), Jim Zimmerman (jimzimmerman.com) and Prabir Shrestha (prabir.me)</author>
// <website>https://github.com/facebook-csharp-sdk/facbook-csharp-sdk</website>
//-----------------------------------------------------------------------

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File".
// You do not need to add suppressions to this file manually.
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Facebook.IFacebookSettings.#CanvasPageUrlPath")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "IDictionary", Scope = "member", Target = "Facebook.FacebookApp.#OauthRequest(System.Uri,System.Object,Facebook.HttpMethod)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "IDictionary", Scope = "member", Target = "Facebook.FacebookApp.#OauthRequestAsync(Facebook.FacebookAsyncCallback,System.Object,System.Uri,System.Object,Facebook.HttpMethod)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "IDictionary", Scope = "member", Target = "Facebook.FacebookApp.#OAuthRequest(System.Uri,System.Object,Facebook.HttpMethod)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "IDictionary", Scope = "member", Target = "Facebook.FacebookApp.#OAuthRequestAsync(Facebook.FacebookAsyncCallback,System.Object,System.Uri,System.Object,Facebook.HttpMethod)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "signedRequest", Scope = "member", Target = "Facebook.FacebookSession.#.ctor(Facebook.FacebookSignedRequest)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "appSecret", Scope = "member", Target = "Facebook.FacebookSession.#Validate(System.Collections.Generic.Dictionary`2<System.String,System.String>,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "apiSecret", Scope = "member", Target = "Facebook.FacebookSession.#.ctor(System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "JsonWriter", Scope = "member", Target = "Facebook.JsonWriter.#Json")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "TextWriter", Scope = "member", Target = "Facebook.JsonWriter.#Json")]

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Facebook.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c33f0459da20317bb7b839935988fff311e5f24c9719157a6552fc43d0c1f73f3f6af7b4d62aec8e30ae7639f0aa942e3a7a61ad19acd83886efe42bb0c3453afb1b53e31dea327fb0e0f1c13578b53a402fc1193ecde8acfbb125939d88a950f1bb4569ce67319b2c9774f6169354a64bcba0bb6f449ab3d8a7be56e83ed9a6")]
