using System;
using AgoraRtcKitBinding;
using Foundation;

namespace AgoraRtcKitBinding {
	// @interface AgoraExtensionContext : NSObject
	[BaseType (typeof (NSObject))]
	interface AgoraExtensionContext {
		// @property (assign, nonatomic) BOOL isValid;
		[Export ("isValid")]
		bool IsValid { get; set; }

		// @property (assign, nonatomic) NSUInteger uid;
		[Export ("uid")]
		nuint Uid { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable providerName;
		[NullAllowed, Export ("providerName")]
		string ProviderName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable extensionName;
		[NullAllowed, Export ("extensionName")]
		string ExtensionName { get; set; }
	}

	// @protocol AgoraMediaFilterEventDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface AgoraMediaFilterEventDelegate {
		// @optional -(void)onEventWithContext:(AgoraExtensionContext * _Nonnull)context key:(NSString * _Nullable)key value:(NSString * _Nullable)value __attribute__((swift_name("onEventWithContext(_:key:value:)")));
		[Export ("onEventWithContext:key:value:")]
		void OnEventWithContext (AgoraExtensionContext context, [NullAllowed] string key, [NullAllowed] string value);

		// @optional -(void)onExtensionStartedWithContext:(AgoraExtensionContext * _Nonnull)context __attribute__((swift_name("onExtensionStartedWithContext(_:)")));
		[Export ("onExtensionStartedWithContext:")]
		void OnExtensionStartedWithContext (AgoraExtensionContext context);

		// @optional -(void)onExtensionStoppedWithContext:(AgoraExtensionContext * _Nonnull)context __attribute__((swift_name("onExtensionStoppedWithContext(_:)")));
		[Export ("onExtensionStoppedWithContext:")]
		void OnExtensionStoppedWithContext (AgoraExtensionContext context);

		// @optional -(void)onExtensionErrorWithContext:(AgoraExtensionContext * _Nonnull)context error:(int)error message:(NSString * _Nullable)message __attribute__((swift_name("onExtensionErrorWithContext(_:error:message:)")));
		[Export ("onExtensionErrorWithContext:error:message:")]
		void OnExtensionErrorWithContext (AgoraExtensionContext context, int error, [NullAllowed] string message);
	}
}
