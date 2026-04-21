using System;
using AgoraRtcKitBinding;
using UIKit;
using CoreFoundation;
using CoreMedia;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace AgoraRtcKitBinding {
	// @interface AgoraRtcEngineKit : NSObject
	[BaseType (typeof (NSObject))]
	interface AgoraRtcEngineKit {
		
		// +(instancetype _Nonnull)sharedEngineWithAppId:(NSString * _Nonnull)appId delegate:(id<AgoraRtcEngineDelegate> _Nullable)delegate __attribute__((swift_name("sharedEngine(withAppId:delegate:)")));
		[Static]
		[Export ("sharedEngineWithAppId:delegate:")]
		AgoraRtcEngineKit SharedEngineWithAppId (string appId, [NullAllowed] AgoraRtcEngineDelegate @delegate);

	}
}
