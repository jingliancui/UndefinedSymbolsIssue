using System;
using AgoraRtcKitBinding;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace AgoraRtcKitBinding {
	// @protocol AgoraRtcEngineDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface AgoraRtcEngineDelegate {}
}
