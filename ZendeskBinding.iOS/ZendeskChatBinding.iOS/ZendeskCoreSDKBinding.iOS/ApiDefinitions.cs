using System;
using ChatSDKBinding;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace ZendeskCoreSDKBinding
{
	// @interface ZDKCoreLogger : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKCoreLogger
	{
		// @property (nonatomic, class) enum ZDKLogLevel logLevel;
		[Static]
		[Export("logLevel", ArgumentSemantic.Assign)]
		ZDKLogLevel LogLevel { get; set; }

		// @property (nonatomic, class) BOOL enabled;
		[Static]
		[Export("enabled")]
		bool Enabled { get; set; }

		// +(void)error:(NSString * _Nonnull)message;
		[Static]
		[Export("error:")]
		void Error(string message);

		// +(void)warn:(NSString * _Nonnull)message;
		[Static]
		[Export("warn:")]
		void Warn(string message);

		// +(void)info:(NSString * _Nonnull)message;
		[Static]
		[Export("info:")]
		void Info(string message);

		// +(void)debug:(NSString * _Nonnull)message;
		[Static]
		[Export("debug:")]
		void Debug(string message);

		// +(void)verbose:(NSString * _Nonnull)message;
		[Static]
		[Export("verbose:")]
		void Verbose(string message);
	}

	// @interface ZDKHelpCenterUtil : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKHelpCenterUtil
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nullable zendeskURL;
		[Static]
		[NullAllowed, Export("zendeskURL")]
		string ZendeskURL { get; }

		// @property (readonly, nonatomic, class) BOOL hasAuth;
		[Static]
		[Export("hasAuth")]
		bool HasAuth { get; }

		// +(NSURLRequest * _Nonnull)canonicalRequestFor:(NSURLRequest * _Nonnull)request __attribute__((warn_unused_result("")));
		[Static]
		[Export("canonicalRequestFor:")]
		NSUrlRequest CanonicalRequestFor(NSUrlRequest request);
	}

	// @protocol IdentityMigration <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol(Name = "_TtP14ZendeskCoreSDK17IdentityMigration_")]
	[BaseType(typeof(NSObject), Name = "_TtP14ZendeskCoreSDK17IdentityMigration_")]
	interface IdentityMigration
	{
		// @required -(NSString * _Nullable)getMigratedAnonymousName __attribute__((warn_unused_result("")));
		[Abstract]
		[NullAllowed, Export("getMigratedAnonymousName")]
		//[Verify(MethodToProperty)]
		string MigratedAnonymousName { get; }

		// @required -(NSString * _Nullable)getMigratedAnonymousEmail __attribute__((warn_unused_result("")));
		[Abstract]
		[NullAllowed, Export("getMigratedAnonymousEmail")]
		//[Verify(MethodToProperty)]
		string MigratedAnonymousEmail { get; }

		// @required -(NSString * _Nullable)getMigratedJwtIdentifier __attribute__((warn_unused_result("")));
		[Abstract]
		[NullAllowed, Export("getMigratedJwtIdentifier")]
		//[Verify(MethodToProperty)]
		string MigratedJwtIdentifier { get; }
	}

	// @interface ZDKUser : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKUser
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull content_url;
		[Export("content_url")]
		string Content_url { get; }

		// @property (readonly, nonatomic) BOOL agent;
		[Export("agent")]
		bool Agent { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull tags;
		[Export("tags", ArgumentSemantic.Copy)]
		string[] Tags { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull user_fields;
		[Export("user_fields", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> User_fields { get; }
	}

	// @interface ZDKUserField : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKUserField:INativeObject
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull url;
		[Export("url")]
		string Url { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull key;
		[Export("key")]
		string Key { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull fieldType;
		[Export("fieldType")]
		string FieldType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
		[Export("title")]
		string Title { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull raw_title;
		[Export("raw_title")]
		string Raw_title { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull fieldDescription;
		[Export("fieldDescription")]
		string FieldDescription { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull raw_description;
		[Export("raw_description")]
		string Raw_description { get; }

		// @property (readonly, nonatomic) NSInteger position;
		[Export("position")]
		nint Position { get; }

		// @property (readonly, nonatomic) BOOL active;
		[Export("active")]
		bool Active { get; }

		// @property (readonly, nonatomic) BOOL system;
		[Export("system")]
		bool System { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull regexp_for_validation;
		[Export("regexp_for_validation")]
		string Regexp_for_validation { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull created_at;
		[Export("created_at", ArgumentSemantic.Copy)]
		NSDate Created_at { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull updated_at;
		[Export("updated_at", ArgumentSemantic.Copy)]
		NSDate Updated_at { get; }

		// @property (readonly, copy, nonatomic) NSArray<ZDKUserFieldOption *> * _Nullable custom_field_options;
		[NullAllowed, Export("custom_field_options", ArgumentSemantic.Copy)]
		ZDKUserFieldOption[] Custom_field_options { get; }
	}

	// @interface ZDKUserFieldOption : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKUserFieldOption
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; }

		// @property (readonly, nonatomic) NSInteger position;
		[Export("position")]
		nint Position { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull raw_name;
		[Export("raw_name")]
		string Raw_name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull url;
		[Export("url")]
		string Url { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull value;
		[Export("value")]
		string Value { get; }
	}

	// @protocol ZDKObjCIdentity
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	//[BaseType(typeof(NSObject))]
	[Protocol(Name = "_TtP14ZendeskCoreSDK15ZDKObjCIdentity_")]
	interface ZDKObjCIdentity
	{
	}
	interface IZDKObjCIdentity { }

	// @interface ZDKObjCAnonymous : NSObject <ZDKObjCIdentity>
	[BaseType(typeof(NSObject), Name = "_TtC14ZendeskCoreSDK16ZDKObjCAnonymous")]
	[DisableDefaultCtor]
	interface ZDKObjCAnonymous : IZDKObjCIdentity
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable guid;
		[NullAllowed, Export("guid")]
		string Guid { get; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nullable)name email:(NSString * _Nullable)email __attribute__((objc_designated_initializer));
		[Export("initWithName:email:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] string name, [NullAllowed] string email);
	}

	// @interface ZDKObjCJwt : NSObject <ZDKObjCIdentity>
	[BaseType(typeof(NSObject), Name = "_TtC14ZendeskCoreSDK10ZDKObjCJwt")]
	[DisableDefaultCtor]
	interface ZDKObjCJwt : IZDKObjCIdentity
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull token;
		[Export("token")]
		string Token { get; }

		// -(instancetype _Nonnull)initWithToken:(NSString * _Nonnull)token __attribute__((objc_designated_initializer));
		[Export("initWithToken:")]
		[DesignatedInitializer]
		IntPtr Constructor(string token);
	}

	// @interface ZDKPushProvider : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC14ZendeskCoreSDK15ZDKPushProvider")]
	[DisableDefaultCtor]
	interface ZDKPushProvider
	{
		// -(instancetype _Nonnull)initWithZendesk:(ZDKZendesk * _Nonnull)zendesk __attribute__((objc_designated_initializer));
		[Export("initWithZendesk:")]
		[DesignatedInitializer]
		IntPtr Constructor(ZDKZendesk zendesk);

		// -(void)registerWithDeviceIdentifier:(NSString * _Nonnull)deviceIdentifier locale:(NSString * _Nonnull)locale completion:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
		[Export("registerWithDeviceIdentifier:locale:completion:")]
		void RegisterWithDeviceIdentifier(string deviceIdentifier, string locale, Action<NSString, NSError> completion);

		// -(void)registerWithUAIdentifier:(NSString * _Nonnull)UAIdentifier locale:(NSString * _Nonnull)locale completion:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
		[Export("registerWithUAIdentifier:locale:completion:")]
		void RegisterWithUAIdentifier(string UAIdentifier, string locale, Action<NSString, NSError> completion);

		// -(void)unregisterForPush;
		[Export("unregisterForPush")]
		void UnregisterForPush();
	}

	// @interface ZDKUserProvider : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC14ZendeskCoreSDK15ZDKUserProvider")]
	[DisableDefaultCtor]
	interface ZDKUserProvider
	{
		// -(instancetype _Nonnull)initWithZendesk:(ZDKZendesk * _Nonnull)zendesk __attribute__((objc_designated_initializer));
		[Export("initWithZendesk:")]
		[DesignatedInitializer]
		IntPtr Constructor(ZDKZendesk zendesk);

		// -(void)getUserWithCompletion:(void (^ _Nonnull)(ZDKUser * _Nullable, NSError * _Nullable))completion;
		[Export("getUserWithCompletion:")]
		void GetUserWithCompletion(Action<ZDKUser, NSError> completion);

		// -(void)setUserFields:(NSDictionary<NSString *,id> * _Nonnull)userFields completion:(void (^ _Nonnull)(ZDKUser * _Nullable, NSError * _Nullable))completion;
		[Export("setUserFields:completion:")]
		void SetUserFields(NSDictionary<NSString, NSObject> userFields, Action<ZDKUser, NSError> completion);

		// -(void)getUserFieldsWithCompletion:(void (^ _Nonnull)(NSArray<ZDKUserField *> * _Nonnull, NSError * _Nullable))completion;
		[Export("getUserFieldsWithCompletion:")]
		void GetUserFieldsWithCompletion(Action<NSArray<ZDKUserField>, NSError> completion);

		// -(void)addTags:(NSArray<NSString *> * _Nonnull)tags :(void (^ _Nonnull)(NSArray<NSString *> * _Nonnull, NSError * _Nullable))completion;
		[Export("addTags::")]
		void AddTags(string[] tags, Action<NSArray<NSString>, NSError> completion);

		// -(void)deleteTags:(NSArray<NSString *> * _Nonnull)tags completion:(void (^ _Nonnull)(NSArray<NSString *> * _Nonnull, NSError * _Nullable))completion;
		[Export("deleteTags:completion:")]
		void DeleteTags(string[] tags, Action<NSArray<NSString>, NSError> completion);
	}

	// @interface ZDKZendesk : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKZendesk
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull zendeskUrl;
		[Export("zendeskUrl")]
		string ZendeskUrl { get; }

		// +(void)initializeWithAppId:(NSString * _Nonnull)appId clientId:(NSString * _Nonnull)clientId zendeskUrl:(NSString * _Nonnull)zendeskUrl;
		[Static]
		[Export("initializeWithAppId:clientId:zendeskUrl:")]
		void InitializeWithAppId(string appId, string clientId, string zendeskUrl);

		// @property (readonly, nonatomic, strong, class) ZDKZendesk * _Nullable instance;
		[Static]
		[NullAllowed, Export("instance", ArgumentSemantic.Strong)]
		ZDKZendesk Instance { get; }

		// -(void)setIdentity:(id<ZDKObjCIdentity> _Nonnull)newIdentity;
		[Export("setIdentity:")]
		void SetIdentity(ZDKObjCAnonymous newIdentity);

		// -(id<ZDKObjCIdentity> _Nullable)objCIdentity __attribute__((warn_unused_result("")));
		[NullAllowed, Export("objCIdentity")]
		//[Verify(MethodToProperty)]
		ZDKObjCAnonymous ObjCIdentity { get; }
	}

	//// @interface ZendeskCoreSDK_Swift_1556 (ZDKZendesk)
	//[Category]
	//[BaseType(typeof(ZDKZendesk))]
	//interface ZDKZendesk_ZendeskCoreSDK_Swift_1556
	//{
	//	// @property (readonly, nonatomic, strong, class) ZDKZendesk * _Nullable instance;
	//	[Static]
	//	[NullAllowed, Export("instance", ArgumentSemantic.Strong)]
	//	ZDKZendesk Instance { get; }

	//	// -(void)setIdentity:(id<ZDKObjCIdentity> _Nonnull)newIdentity;
	//	[Export("setIdentity:")]
	//	void SetIdentity(ZDKObjCIdentity newIdentity);

	//	// -(id<ZDKObjCIdentity> _Nullable)objCIdentity __attribute__((warn_unused_result("")));
	//	[NullAllowed, Export("objCIdentity")]
	//	//[Verify(MethodToProperty)]
	//	ZDKObjCIdentity ObjCIdentity { get; }
	//}
}



namespace ChatProvidersSDKBinding
{
	// @interface ZDKChatAccount : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKChatAccount
	{
		// @property (readonly, nonatomic) enum ZDKChatAccountStatus accountStatus;
		[Export("accountStatus")]
		ZDKChatAccountStatus AccountStatus { get; }

		// @property (readonly, copy, nonatomic) NSArray<ZDKDepartment *> * _Nullable departments;
		[NullAllowed, Export("departments", ArgumentSemantic.Copy)]
		ZDKDepartment[] Departments { get; }

		// -(instancetype _Nonnull)initWithAccountStatus:(enum ZDKChatAccountStatus)accountStatus departments:(NSArray<ZDKDepartment *> * _Nullable)departments __attribute__((objc_designated_initializer));
		[Export("initWithAccountStatus:departments:")]
		[DesignatedInitializer]
		IntPtr Constructor(ZDKChatAccountStatus accountStatus, [NullAllowed] ZDKDepartment[] departments);

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// -(BOOL)containsDepartmentWith:(NSString * _Nonnull)name __attribute__((warn_unused_result("")));
		[Export("containsDepartmentWith:")]
		bool ContainsDepartmentWith(string name);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	// @interface ZDKChatAccountProvider : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKChatAccountProvider
	{
		// -(ZDKObservationToken * _Nonnull)observeAccount:(void (^ _Nonnull)(ZDKChatAccount * _Nonnull))completion __attribute__((warn_unused_result("")));
		[Export("observeAccount:")]
		ZDKObservationToken ObserveAccount(Action<ZDKChatAccount> completion);
	}

	// @interface ChatProvidersSDK_Swift_2937 (ZDKChatAccountProvider)
	[Category]
	[BaseType(typeof(ZDKChatAccountProvider))]
	interface ZDKChatAccountProvider_ChatProvidersSDK_Swift_2937
	{
		// -(void)getAccount:(void (^ _Nonnull)(ZDKChatAccount * _Nullable, NSError * _Nullable))completion;
		[Export("getAccount:")]
		void GetAccount(Action<ZDKChatAccount, NSError> completion);
	}

	// @interface ZDKAgent : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKAgent
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull nick;
		[Export("nick")]
		string Nick { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull displayName;
		[Export("displayName")]
		string DisplayName { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable avatar;
		[NullAllowed, Export("avatar", ArgumentSemantic.Copy)]
		NSUrl Avatar { get; }

		// @property (readonly, nonatomic) BOOL isTyping;
		[Export("isTyping")]
		bool IsTyping { get; }

		// -(instancetype _Nonnull)initWithAvatar:(NSURL * _Nullable)avatar nick:(NSString * _Nonnull)nick displayName:(NSString * _Nonnull)displayName isTyping:(BOOL)isTyping __attribute__((objc_designated_initializer));
		[Export("initWithAvatar:nick:displayName:isTyping:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] NSUrl avatar, string nick, string displayName, bool isTyping);

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	// @interface ZDKChat : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKChat
	{
		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull NotificationMessageReceived;
		[Static]
		[Export("NotificationMessageReceived")]
		string NotificationMessageReceived { get; }

		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull NotificationChatEnded;
		[Static]
		[Export("NotificationChatEnded")]
		string NotificationChatEnded { get; }

		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull NotificationAuthenticationFailed;
		[Static]
		[Export("NotificationAuthenticationFailed")]
		string NotificationAuthenticationFailed { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull accountKey;
		[Export("accountKey")]
		string AccountKey { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable appId;
		[NullAllowed, Export("appId")]
		string AppId { get; }

		// @property (readonly, nonatomic, strong) ZDKChatProviders * _Nonnull providers;
		[Export("providers", ArgumentSemantic.Strong)]
		ZDKChatProviders Providers { get; }

		// @property (readonly, nonatomic, strong, class) ZDKChat * _Nullable instance;
		[Static]
		[NullAllowed, Export("instance", ArgumentSemantic.Strong)]
		ZDKChat Instance { get; }

		// @property (nonatomic, strong) ZDKChatAPIConfiguration * _Nonnull configuration;
		[Export("configuration", ArgumentSemantic.Strong)]
		ZDKChatAPIConfiguration Configuration { get; set; }

		// @property (readonly, nonatomic, class) BOOL hasIdentity;
		[Static]
		[Export("hasIdentity")]
		bool HasIdentity { get; }

		// @property (readonly, nonatomic, strong, class) ZDKChatAccountProvider * _Nullable accountProvider;
		[Static]
		[NullAllowed, Export("accountProvider", ArgumentSemantic.Strong)]
		ZDKChatAccountProvider AccountProvider { get; }

		// @property (readonly, nonatomic, strong, class) ZDKConnectionProvider * _Nullable connectionProvider;
		[Static]
		[NullAllowed, Export("connectionProvider", ArgumentSemantic.Strong)]
		ZDKConnectionProvider ConnectionProvider { get; }

		// @property (readonly, nonatomic, strong, class) ZDKProfileProvider * _Nullable profileProvider;
		[Static]
		[NullAllowed, Export("profileProvider", ArgumentSemantic.Strong)]
		ZDKProfileProvider ProfileProvider { get; }

		// @property (readonly, nonatomic, strong, class) ZDKPushNotificationsProvider * _Nullable pushNotificationsProvider;
		[Static]
		[NullAllowed, Export("pushNotificationsProvider", ArgumentSemantic.Strong)]
		ZDKPushNotificationsProvider PushNotificationsProvider { get; }

		// @property (readonly, nonatomic, strong, class) ZDKChatProvider * _Nullable chatProvider;
		[Static]
		[NullAllowed, Export("chatProvider", ArgumentSemantic.Strong)]
		ZDKChatProvider ChatProvider { get; }

		// @property (readonly, nonatomic, strong, class) ZDKSettingsProvider * _Nullable settingsProvider;
		[Static]
		[NullAllowed, Export("settingsProvider", ArgumentSemantic.Strong)]
		ZDKSettingsProvider SettingsProvider { get; }

		//// @property (readonly, nonatomic) BOOL hasIdentity;
		//[Export ("hasIdentity")]
		//bool HasIdentity { get; }

		//// @property (readonly, nonatomic, strong) ZDKChatAccountProvider * _Nonnull accountProvider;
		//[Export ("accountProvider", ArgumentSemantic.Strong)]
		//ZDKChatAccountProvider AccountProvider { get; }

		//// @property (readonly, nonatomic, strong) ZDKConnectionProvider * _Nonnull connectionProvider;
		//[Export ("connectionProvider", ArgumentSemantic.Strong)]
		//ZDKConnectionProvider ConnectionProvider { get; }

		//// @property (readonly, nonatomic, strong) ZDKPushNotificationsProvider * _Nonnull pushNotificationsProvider;
		//[Export ("pushNotificationsProvider", ArgumentSemantic.Strong)]
		//ZDKPushNotificationsProvider PushNotificationsProvider { get; }

		//// @property (readonly, nonatomic, strong) ZDKProfileProvider * _Nonnull profileProvider;
		//[Export ("profileProvider", ArgumentSemantic.Strong)]
		//ZDKProfileProvider ProfileProvider { get; }

		//// @property (readonly, nonatomic, strong) ZDKChatProvider * _Nonnull chatProvider;
		//[Export ("chatProvider", ArgumentSemantic.Strong)]
		//ZDKChatProvider ChatProvider { get; }

		//// @property (readonly, nonatomic, strong) ZDKSettingsProvider * _Nonnull settingsProvider;
		//[Export ("settingsProvider", ArgumentSemantic.Strong)]
		//ZDKSettingsProvider SettingsProvider { get; }

		// +(void)initializeWithAccountKey:(NSString * _Nonnull)accountKey appId:(NSString * _Nullable)appId queue:(dispatch_queue_t _Nonnull)queue;
		[Static]
		[Export("initializeWithAccountKey:appId:queue:")]
		void InitializeWithAccountKey(string accountKey, [NullAllowed] string appId, DispatchQueue queue);

		// +(void)initializeWithAccountKey:(NSString * _Nonnull)accountKey queue:(dispatch_queue_t _Nonnull)queue;
		[Static]
		[Export("initializeWithAccountKey:queue:")]
		void InitializeWithAccountKey(string accountKey, DispatchQueue queue);

		// -(void)clearCache;
		[Export("clearCache")]
		void ClearCache();

		// -(void)setIdentityWithAuthenticator:(id<ZDKJWTAuthenticator> _Nonnull)authenticator;
		[Export("setIdentityWithAuthenticator:")]
		void SetIdentityWithAuthenticator(ZDKJWTAuthenticator authenticator);

		// -(void)resetIdentity:(void (^ _Nullable)(void))completion;
		[Export("resetIdentity:")]
		void ResetIdentity([NullAllowed] Action completion);

		// -(void)resetIdentity __attribute__((deprecated("Please use `resetIdentity(_ completion: (() -> Void)?)` instead")));
		[Export("resetIdentity")]
		void ResetIdentity();
	}

	// @interface ChatProvidersSDK_Swift_3093 (ZDKChat)
	[Category]
	[BaseType(typeof(ZDKChat))]
	interface ZDKChat_ChatProvidersSDK_Swift_3093
	{
		// +(void)registerPushToken:(NSData * _Nonnull)pushTokenData;
		[Static]
		[Export("registerPushToken:")]
		void RegisterPushToken(NSData pushTokenData);

		// +(void)didReceiveRemoteNotification:(NSDictionary * _Nonnull)userInfo in:(UIApplication * _Nonnull)application;
		[Static]
		[Export("didReceiveRemoteNotification:in:")]
		void DidReceiveRemoteNotification(NSDictionary userInfo, UIApplication application);
	}

	// @interface ZDKChatAPIConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKChatAPIConfiguration
	{
		// @property (copy, nonatomic) NSString * _Nullable visitorPathOne;
		[NullAllowed, Export("visitorPathOne")]
		string VisitorPathOne { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull visitorPathTwo;
		[Export("visitorPathTwo")]
		string VisitorPathTwo { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable visitorPathTwoValue;
		[NullAllowed, Export("visitorPathTwoValue")]
		string VisitorPathTwoValue { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull tags;
		[Export("tags", ArgumentSemantic.Copy)]
		string[] Tags { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable department;
		[NullAllowed, Export("department")]
		string Department { get; set; }

		// @property (nonatomic, strong) ZDKVisitorInfo * _Nullable visitorInfo;
		[NullAllowed, Export("visitorInfo", ArgumentSemantic.Strong)]
		ZDKVisitorInfo VisitorInfo { get; set; }
	}

	// @interface ChatProvidersSDK_Swift_3166 (ZDKChatAPIConfiguration)
	[Category]
	[BaseType(typeof(ZDKChatAPIConfiguration))]
	interface ZDKChatAPIConfiguration_ChatProvidersSDK_Swift_3166
	{
		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
	}

	// @interface ZDKChatAttachment : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKChatAttachment
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull mimeType;
		[Export("mimeType")]
		string MimeType { get; }

		// @property (readonly, nonatomic) NSInteger size;
		[Export("size")]
		nint Size { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull url;
		[Export("url")]
		string Url { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable localURL;
		[NullAllowed, Export("localURL", ArgumentSemantic.Copy)]
		NSUrl LocalURL { get; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name mimeType:(NSString * _Nonnull)mimeType size:(NSInteger)size url:(NSString * _Nonnull)url localURL:(NSURL * _Nullable)localURL;
		[Export("initWithName:mimeType:size:url:localURL:")]
		IntPtr Constructor(string name, string mimeType, nint size, string url, [NullAllowed] NSUrl localURL);

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	// @interface ZDKChatLog : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKChatLog
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull nick;
		[Export("nick")]
		string Nick { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull displayName;
		[Export("displayName")]
		string DisplayName { get; }

		// @property (readonly, nonatomic) NSTimeInterval createdTimestamp;
		[Export("createdTimestamp")]
		double CreatedTimestamp { get; }

		// @property (readonly, nonatomic) NSTimeInterval lastModifiedTimestamp;
		[Export("lastModifiedTimestamp")]
		double LastModifiedTimestamp { get; }

		// @property (readonly, nonatomic) enum ZDKChatLogType type;
		[Export("type")]
		ZDKChatLogType Type { get; }

		// @property (readonly, nonatomic) enum ZDKChatParticipant participant;
		[Export("participant")]
		ZDKChatParticipant Participant { get; }

		// @property (readonly, nonatomic) BOOL createdByVisitor;
		[Export("createdByVisitor")]
		bool CreatedByVisitor { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, nonatomic) enum ZDKDeliveryStatus deliveryStatus;
		[Export("deliveryStatus")]
		ZDKDeliveryStatus DeliveryStatus { get; }
	}

	// @interface ZDKChatAttachmentMessage : ZDKChatLog
	[BaseType(typeof(ZDKChatLog))]
	interface ZDKChatAttachmentMessage
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export("message")]
		string Message { get; }

		// @property (readonly, nonatomic, strong) ZDKChatAttachment * _Nonnull attachment;
		[Export("attachment", ArgumentSemantic.Strong)]
		ZDKChatAttachment Attachment { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable url;
		[NullAllowed, Export("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
	}

	// @interface ZDKChatComment : ZDKChatLog
	[BaseType(typeof(ZDKChatLog))]
	interface ZDKChatComment
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable comment;
		[NullAllowed, Export("comment")]
		string Comment { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull newComment;
		[Export("newComment")]
		string NewComment { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	//// @interface ChatProvidersSDK_Swift_3269 (ZDKChatComment)
	//[Category]
	//[BaseType (typeof(ZDKChatComment))]
	//interface ZDKChatComment_ChatProvidersSDK_Swift_3269
	//{
	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	//	[Export ("description")]
	//	string Description { get; }

	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
	//	[Export ("debugDescription")]
	//	string DebugDescription { get; }
	//}

	// @interface ZDKChatInfo : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKChatInfo
	{
		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, nonatomic) BOOL isChatting;
		[Export("isChatting")]
		bool IsChatting { get; }

		// -(instancetype _Nonnull)initWithIsChatting:(BOOL)isChatting __attribute__((objc_designated_initializer));
		[Export("initWithIsChatting:")]
		[DesignatedInitializer]
		IntPtr Constructor(bool isChatting);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	//// @interface ChatProvidersSDK_Swift_3313 (ZDKChatLog)
	//[Category]
	//[BaseType (typeof(ZDKChatLog))]
	//interface ZDKChatLog_ChatProvidersSDK_Swift_3313
	//{
	//	// @property (readonly, nonatomic) enum ZDKDeliveryStatus deliveryStatus;
	//	[Export ("deliveryStatus")]
	//	ZDKDeliveryStatus DeliveryStatus { get; }
	//}

	// @interface ZDKChatMemberJoin : ZDKChatLog
	[BaseType(typeof(ZDKChatLog))]
	interface ZDKChatMemberJoin
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	//// @interface ChatProvidersSDK_Swift_3345 (ZDKChatMemberJoin)
	//[Category]
	//[BaseType (typeof(ZDKChatMemberJoin))]
	//interface ZDKChatMemberJoin_ChatProvidersSDK_Swift_3345
	//{
	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	//	[Export ("description")]
	//	string Description { get; }

	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
	//	[Export ("debugDescription")]
	//	string DebugDescription { get; }
	//}

	// @interface ZDKChatMemberLeave : ZDKChatLog
	[BaseType(typeof(ZDKChatLog))]
	interface ZDKChatMemberLeave
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	// @interface ChatProvidersSDK_Swift_3360 (ZDKChatMemberLeave)
	//[Category]
	//[BaseType (typeof(ZDKChatMemberLeave))]
	//interface ZDKChatMemberLeave_ChatProvidersSDK_Swift_3360
	//{
	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	//	[Export ("description")]
	//	string Description { get; }

	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
	//	[Export ("debugDescription")]
	//	string DebugDescription { get; }
	//}

	// @interface ZDKChatMessage : ZDKChatLog
	[BaseType(typeof(ZDKChatLog))]
	interface ZDKChatMessage
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export("message")]
		string Message { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	//// @interface ChatProvidersSDK_Swift_3381 (ZDKChatMessage)
	//[Category]
	//[BaseType (typeof(ZDKChatMessage))]
	//interface ZDKChatMessage_ChatProvidersSDK_Swift_3381
	//{
	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	//	[Export ("description")]
	//	string Description { get; }

	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
	//	[Export ("debugDescription")]
	//	string DebugDescription { get; }
	//}

	// @interface ZDKChatOptionsMessage : ZDKChatLog
	[BaseType(typeof(ZDKChatLog))]
	interface ZDKChatOptionsMessage
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export("message")]
		string Message { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull options;
		[Export("options", ArgumentSemantic.Copy)]
		string[] Options { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	// @interface ChatProvidersSDK_Swift_3404 (ZDKChatOptionsMessage)
	//[Category]
	//[BaseType (typeof(ZDKChatOptionsMessage))]
	//interface ZDKChatOptionsMessage_ChatProvidersSDK_Swift_3404
	//{
	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	//	[Export ("description")]
	//	string Description { get; }

	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
	//	[Export ("debugDescription")]
	//	string DebugDescription { get; }
	//}

	// @interface ZDKChatProvider : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKChatProvider
	{
		// @property (readonly, nonatomic, strong) ZDKChatState * _Nonnull chatState;
		[Export("chatState", ArgumentSemantic.Strong)]
		ZDKChatState ChatState { get; }

		// -(void)requestChat;
		[Export("requestChat")]
		void RequestChat();

		// -(void)sendTypingWithIsTyping:(BOOL)isTyping;
		[Export("sendTypingWithIsTyping:")]
		void SendTypingWithIsTyping(bool isTyping);

		// -(ZDKObservationToken * _Nonnull)observeChatState:(void (^ _Nonnull)(ZDKChatState * _Nonnull))completion __attribute__((warn_unused_result("")));
		[Export("observeChatState:")]
		ZDKObservationToken ObserveChatState(Action<ZDKChatState> completion);
	}

	// @interface ChatProvidersSDK_Swift_3470 (ZDKChatProvider)
	[Category]
	[BaseType(typeof(ZDKChatProvider))]
	interface ZDKChatProvider_ChatProvidersSDK_Swift_3470
	{
		// -(void)getChatInfo:(void (^ _Nonnull)(ZDKChatInfo * _Nullable, NSError * _Nullable))completion;
		[Export("getChatInfo:")]
		void GetChatInfo(Action<ZDKChatInfo, NSError> completion);

		// -(void)sendMessage:(NSString * _Nonnull)message completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
		[Export("sendMessage:completion:")]
		void SendMessage(string message, [NullAllowed] Action<NSString, NSError> completion);

		// -(void)sendOfflineForm:(ZDKOfflineForm * _Nonnull)offlineForm completion:(void (^ _Nullable)(ZDKOfflineForm * _Nullable, NSError * _Nullable))completion;
		[Export("sendOfflineForm:completion:")]
		void SendOfflineForm(ZDKOfflineForm offlineForm, [NullAllowed] Action<ZDKOfflineForm, NSError> completion);

		// -(void)resendFailedMessageWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
		[Export("resendFailedMessageWithId:completion:")]
		void ResendFailedMessageWithId(string id, [NullAllowed] Action<NSString, NSError> completion);

		// -(void)deleteFailedMessageWithId:(NSString * _Nonnull)id completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
		[Export("deleteFailedMessageWithId:completion:")]
		void DeleteFailedMessageWithId(string id, [NullAllowed] Action<NSString, NSError> completion);

		// -(void)sendFileWithUrl:(NSURL * _Nonnull)url onProgress:(void (^ _Nullable)(double))onProgress completion:(void (^ _Nullable)(NSString * _Nullable, ZDKChatAttachmentMessage * _Nullable, NSError * _Nullable))completion;
		[Export("sendFileWithUrl:onProgress:completion:")]
		void SendFileWithUrl(NSUrl url, [NullAllowed] Action<double> onProgress, [NullAllowed] Action<NSString, ZDKChatAttachmentMessage, NSError> completion);

		// -(void)resendFailedFileWithId:(NSString * _Nonnull)id onProgress:(void (^ _Nullable)(double))onProgress completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
		[Export("resendFailedFileWithId:onProgress:completion:")]
		void ResendFailedFileWithId(string id, [NullAllowed] Action<double> onProgress, [NullAllowed] Action<NSString, NSError> completion);

		// -(void)sendChatRating:(enum ZDKRating)rating completion:(void (^ _Nullable)(enum ZDKRating, NSError * _Nullable))completion;
		[Export("sendChatRating:completion:")]
		void SendChatRating(ZDKRating rating, [NullAllowed] Action<ZDKRating, NSError> completion);

		// -(void)sendChatComment:(NSString * _Nonnull)comment completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
		[Export("sendChatComment:completion:")]
		void SendChatComment(string comment, [NullAllowed] Action<NSString, NSError> completion);

		// -(void)sendEmailTranscript:(NSString * _Nonnull)email completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
		[Export("sendEmailTranscript:completion:")]
		void SendEmailTranscript(string email, [NullAllowed] Action<NSString, NSError> completion);

		// -(void)endChat:(void (^ _Nullable)(BOOL, NSError * _Nullable))completion;
		[Export("endChat:")]
		void EndChat([NullAllowed] Action<bool, NSError> completion);
	}

	// @interface ZDKChatRating : ZDKChatLog
	[BaseType(typeof(ZDKChatLog))]
	interface ZDKChatRating
	{
		// @property (readonly, nonatomic) enum ZDKRating ratingValue;
		[Export("ratingValue")]
		ZDKRating RatingValue { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	//// @interface ChatProvidersSDK_Swift_3498 (ZDKChatRating)
	//[Category]
	//[BaseType (typeof(ZDKChatRating))]
	//interface ZDKChatRating_ChatProvidersSDK_Swift_3498
	//{
	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	//	[Export ("description")]
	//	string Description { get; }

	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
	//	[Export ("debugDescription")]
	//	string DebugDescription { get; }
	//}

	// @interface ZDKRatingRequest : ZDKChatLog
	[BaseType(typeof(ZDKChatLog))]
	interface ZDKRatingRequest
	{
		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	//// @interface ChatProvidersSDK_Swift_3516 (ZDKRatingRequest)
	//[Category]
	//[BaseType (typeof(ZDKRatingRequest))]
	//interface ZDKRatingRequest_ChatProvidersSDK_Swift_3516
	//{
	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	//	[Export ("description")]
	//	string Description { get; }

	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
	//	[Export ("debugDescription")]
	//	string DebugDescription { get; }
	//}

	// @interface ZDKChatSettings : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKChatSettings
	{
		// @property (readonly, nonatomic, strong, class) ZDKChatSettings * _Nonnull initial;
		[Static]
		[Export("initial", ArgumentSemantic.Strong)]
		ZDKChatSettings Initial { get; }

		// @property (readonly, nonatomic) int64_t fileSizeLimit;
		[Export("fileSizeLimit")]
		long FileSizeLimit { get; }

		// @property (readonly, nonatomic) BOOL isFileSendingEnabled;
		[Export("isFileSendingEnabled")]
		bool IsFileSendingEnabled { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull supportedFileTypes;
		[Export("supportedFileTypes", ArgumentSemantic.Copy)]
		string[] SupportedFileTypes { get; }

		// -(instancetype _Nonnull)initWithFileSizeLimit:(int64_t)fileSizeLimit isFileSendingEnabled:(BOOL)isFileSendingEnabled supportedFileTypes:(NSArray<NSString *> * _Nonnull)supportedFileTypes __attribute__((objc_designated_initializer));
		[Export("initWithFileSizeLimit:isFileSendingEnabled:supportedFileTypes:")]
		[DesignatedInitializer]
		IntPtr Constructor(long fileSizeLimit, bool isFileSendingEnabled, string[] supportedFileTypes);

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	// @interface ZDKChatState : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKChatState
	{
		// @property (readonly, nonatomic, strong, class) ZDKChatState * _Nonnull initial;
		[Static]
		[Export("initial", ArgumentSemantic.Strong)]
		ZDKChatState Initial { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull comment;
		[Export("comment")]
		string Comment { get; }

		// @property (readonly, nonatomic) enum ZDKRating ratingValue;
		[Export("ratingValue")]
		ZDKRating RatingValue { get; }

		// @property (readonly, copy, nonatomic) NSArray<ZDKAgent *> * _Nonnull agents;
		[Export("agents", ArgumentSemantic.Copy)]
		ZDKAgent[] Agents { get; }

		// @property (readonly, nonatomic) BOOL isChatting;
		[Export("isChatting")]
		bool IsChatting { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable chatId;
		[NullAllowed, Export("chatId")]
		string ChatId { get; }

		// @property (readonly, nonatomic, strong) ZDKDepartment * _Nullable department;
		[NullAllowed, Export("department", ArgumentSemantic.Strong)]
		ZDKDepartment Department { get; }

		// @property (readonly, copy, nonatomic) NSArray<ZDKChatLog *> * _Nonnull logs;
		[Export("logs", ArgumentSemantic.Copy)]
		ZDKChatLog[] Logs { get; }

		// @property (nonatomic, strong) ZDKQueuePosition * _Nonnull queuePosition;
		[Export("queuePosition", ArgumentSemantic.Strong)]
		ZDKQueuePosition QueuePosition { get; set; }

		// @property (readonly, nonatomic) enum ChatSessionStatus chatSessionStatus;
		[Export("chatSessionStatus")]
		ChatSessionStatus ChatSessionStatus { get; }

		// -(ZDKChatLog * _Nullable)logWithId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export("logWithId:")]
		[return: NullAllowed]
		ZDKChatLog LogWithId(string id);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }

		// -(instancetype _Nonnull)initWithAgents:(NSArray<ZDKAgent *> * _Nonnull)agents isChatting:(BOOL)isChatting chatId:(NSString * _Nullable)chatId department:(ZDKDepartment * _Nullable)department logs:(NSArray<ZDKChatLog *> * _Nonnull)logs queue:(NSInteger)queue comment:(NSString * _Nonnull)comment rating:(enum ZDKRating)rating;
		[Export("initWithAgents:isChatting:chatId:department:logs:queue:comment:rating:")]
		IntPtr Constructor(ZDKAgent[] agents, bool isChatting, [NullAllowed] string chatId, [NullAllowed] ZDKDepartment department, ZDKChatLog[] logs, nint queue, string comment, ZDKRating rating);

	}

	//// @interface ChatProvidersSDK_Swift_3597 (ZDKChatState)
	//[Category]
	//[BaseType (typeof(ZDKChatState))]
	//interface ZDKChatState_ChatProvidersSDK_Swift_3597
	//{
	//	// -(instancetype _Nonnull)initWithAgents:(NSArray<ZDKAgent *> * _Nonnull)agents isChatting:(BOOL)isChatting chatId:(NSString * _Nullable)chatId department:(ZDKDepartment * _Nullable)department logs:(NSArray<ZDKChatLog *> * _Nonnull)logs queue:(NSInteger)queue comment:(NSString * _Nonnull)comment rating:(enum ZDKRating)rating;
	//	[Export ("initWithAgents:isChatting:chatId:department:logs:queue:comment:rating:")]
	//	IntPtr Constructor (ZDKAgent[] agents, bool isChatting, [NullAllowed] string chatId, [NullAllowed] ZDKDepartment department, ZDKChatLog[] logs, nint queue, string comment, ZDKRating rating);
	//}

	// @interface ChatProvidersSDK_Swift_3602 (ZDKChatState)
	[Category]
	[BaseType(typeof(ZDKChatState))]
	interface ZDKChatState_ChatProvidersSDK_Swift_3602
	{
		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
	}

	// @interface ZDKConnectionProvider : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKConnectionProvider
	{
		// @property (readonly, nonatomic) enum ZDKConnectionStatus status;
		[Export("status")]
		ZDKConnectionStatus Status { get; }

		// -(void)connect;
		[Export("connect")]
		void Connect();

		// -(void)disconnect;
		[Export("disconnect")]
		void Disconnect();

		// -(ZDKObservationToken * _Nonnull)observeConnectionStatus:(void (^ _Nonnull)(enum ZDKConnectionStatus))completion __attribute__((warn_unused_result("")));
		[Export("observeConnectionStatus:")]
		ZDKObservationToken ObserveConnectionStatus(Action<ZDKConnectionStatus> completion);
	}

	// @interface ZDKDepartment : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKDepartment
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; }

		// @property (readonly, nonatomic) enum ZDKDepartmentStatus departmentStatus;
		[Export("departmentStatus")]
		ZDKDepartmentStatus DepartmentStatus { get; }

		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id name:(NSString * _Nonnull)name departmentStatus:(enum ZDKDepartmentStatus)departmentStatus;
		[Export("initWithId:name:departmentStatus:")]
		IntPtr Constructor(string id, string name, ZDKDepartmentStatus departmentStatus);

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	//// @interface ChatProvidersSDK_Swift_3671 (ZDKDepartment)
	//[Category]
	//[BaseType (typeof(ZDKDepartment))]
	//interface ZDKDepartment_ChatProvidersSDK_Swift_3671
	//{
	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	//	[Export ("description")]
	//	string Description { get; }

	//	// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
	//	[Export ("debugDescription")]
	//	string DebugDescription { get; }
	//}

	// @protocol ZDKJWTAuthenticator <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface ZDKJWTAuthenticator
	{
		// @required -(void)getToken:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export("getToken:")]
		void GetToken(Action<NSString, NSError> completion);
	}

	// @interface ZDKChatLogger : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKChatLogger
	{
		// @property (nonatomic, class) enum ZDKChatLogLevel defaultLevel;
		[Static]
		[Export("defaultLevel", ArgumentSemantic.Assign)]
		ZDKChatLogLevel DefaultLevel { get; set; }

		// @property (nonatomic, class) BOOL isEnabled;
		[Static]
		[Export("isEnabled")]
		bool IsEnabled { get; set; }
	}

	// @interface ZDKObservationToken : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKObservationToken
	{
		// -(void)cancel;
		[Export("cancel")]
		void Cancel();
	}

	// @interface ZDKOfflineForm : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKOfflineForm
	{
		// @property (readonly, nonatomic, strong) ZDKVisitorInfo * _Nullable visitorInfo;
		[NullAllowed, Export("visitorInfo", ArgumentSemantic.Strong)]
		ZDKVisitorInfo VisitorInfo { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable departmentId;
		[NullAllowed, Export("departmentId")]
		string DepartmentId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export("message")]
		string Message { get; }

		// -(instancetype _Nonnull)initWithVisitorInfo:(ZDKVisitorInfo * _Nullable)visitorInfo departmentId:(NSString * _Nullable)departmentId message:(NSString * _Nonnull)message __attribute__((objc_designated_initializer));
		[Export("initWithVisitorInfo:departmentId:message:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] ZDKVisitorInfo visitorInfo, [NullAllowed] string departmentId, string message);
	}

	// @interface ChatProvidersSDK_Swift_3763 (ZDKOfflineForm)
	[Category]
	[BaseType(typeof(ZDKOfflineForm))]
	interface ZDKOfflineForm_ChatProvidersSDK_Swift_3763
	{
		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
	}

	// @interface ZDKProfileProvider : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKProfileProvider
	{
		// @property (readonly, nonatomic, strong) ZDKVisitorInfo * _Nonnull visitorInfo;
		[Export("visitorInfo", ArgumentSemantic.Strong)]
		ZDKVisitorInfo VisitorInfo { get; }

		// -(ZDKObservationToken * _Nonnull)observeVisitorInfo:(void (^ _Nonnull)(ZDKVisitorInfo * _Nonnull))completion __attribute__((warn_unused_result("")));
		[Export("observeVisitorInfo:")]
		ZDKObservationToken ObserveVisitorInfo(Action<ZDKVisitorInfo> completion);
	}

	// @interface ChatProvidersSDK_Swift_3790 (ZDKProfileProvider)
	[Category]
	[BaseType(typeof(ZDKProfileProvider))]
	interface ZDKProfileProvider_ChatProvidersSDK_Swift_3790
	{
		// -(void)setVisitorInfo:(ZDKVisitorInfo * _Nonnull)visitorInfo completion:(void (^ _Nullable)(ZDKVisitorInfo * _Nullable, NSError * _Nullable))completion;
		[Export("setVisitorInfo:completion:")]
		void SetVisitorInfo(ZDKVisitorInfo visitorInfo, [NullAllowed] Action<ZDKVisitorInfo, NSError> completion);

		// -(void)trackVisitorPath:(ZDKVisitorPath * _Nonnull)visitorPath completion:(void (^ _Nullable)(ZDKVisitorPath * _Nullable, NSError * _Nullable))completion;
		[Export("trackVisitorPath:completion:")]
		void TrackVisitorPath(ZDKVisitorPath visitorPath, [NullAllowed] Action<ZDKVisitorPath, NSError> completion);

		// -(void)addTags:(NSArray<NSString *> * _Nonnull)tags completion:(void (^ _Nullable)(NSArray<NSString *> * _Nullable, NSError * _Nullable))completion;
		[Export("addTags:completion:")]
		void AddTags(string[] tags, [NullAllowed] Action<NSArray<NSString>, NSError> completion);

		// -(void)removeTags:(NSArray<NSString *> * _Nonnull)tags completion:(void (^ _Nullable)(NSArray<NSString *> * _Nullable, NSError * _Nullable))completion;
		[Export("removeTags:completion:")]
		void RemoveTags(string[] tags, [NullAllowed] Action<NSArray<NSString>, NSError> completion);

		// -(void)appendNote:(NSString * _Nonnull)note completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
		[Export("appendNote:completion:")]
		void AppendNote(string note, [NullAllowed] Action<NSString, NSError> completion);

		// -(void)setNote:(NSString * _Nonnull)note completion:(void (^ _Nullable)(NSString * _Nullable, NSError * _Nullable))completion;
		[Export("setNote:completion:")]
		void SetNote(string note, [NullAllowed] Action<NSString, NSError> completion);
	}

	// @interface ZDKChatProviders : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKChatProviders
	{
		// @property (readonly, nonatomic, strong) ZDKChatAccountProvider * _Nonnull accountProvider;
		[Export("accountProvider", ArgumentSemantic.Strong)]
		ZDKChatAccountProvider AccountProvider { get; }

		// @property (readonly, nonatomic, strong) ZDKConnectionProvider * _Nonnull connectionProvider;
		[Export("connectionProvider", ArgumentSemantic.Strong)]
		ZDKConnectionProvider ConnectionProvider { get; }

		// @property (readonly, nonatomic, strong) ZDKProfileProvider * _Nonnull profileProvider;
		[Export("profileProvider", ArgumentSemantic.Strong)]
		ZDKProfileProvider ProfileProvider { get; }

		// @property (readonly, nonatomic, strong) ZDKPushNotificationsProvider * _Nonnull pushNotificationsProvider;
		[Export("pushNotificationsProvider", ArgumentSemantic.Strong)]
		ZDKPushNotificationsProvider PushNotificationsProvider { get; }

		// @property (readonly, nonatomic, strong) ZDKChatProvider * _Nonnull chatProvider;
		[Export("chatProvider", ArgumentSemantic.Strong)]
		ZDKChatProvider ChatProvider { get; }

		// @property (readonly, nonatomic, strong) ZDKSettingsProvider * _Nonnull settingsProvider;
		[Export("settingsProvider", ArgumentSemantic.Strong)]
		ZDKSettingsProvider SettingsProvider { get; }
	}

	// @interface ZDKPushNotificationData : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKPushNotificationData
	{
		// @property (readonly, nonatomic) enum ZDKPushNotificationType type;
		[Export("type")]
		ZDKPushNotificationType Type { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull userInfo;
		[Export("userInfo", ArgumentSemantic.Copy)]
		NSDictionary UserInfo { get; }

		// +(ZDKPushNotificationData * _Nullable)dataFor:(NSDictionary * _Nonnull)userInfo __attribute__((warn_unused_result("")));
		[Static]
		[Export("dataFor:")]
		[return: NullAllowed]
		ZDKPushNotificationData DataFor(NSDictionary userInfo);

		// +(BOOL)isChatPushNotificationWithUserInfo:(NSDictionary * _Nonnull)userInfo __attribute__((warn_unused_result("")));
		[Static]
		[Export("isChatPushNotificationWithUserInfo:")]
		bool IsChatPushNotificationWithUserInfo(NSDictionary userInfo);
	}

	// @interface ChatProvidersSDK_Swift_3845 (ZDKPushNotificationData)
	[Category]
	[BaseType(typeof(ZDKPushNotificationData))]
	interface ZDKPushNotificationData_ChatProvidersSDK_Swift_3845
	{
		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
	}

	// @interface ZDKPushNotificationsProvider : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKPushNotificationsProvider
	{
		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull ChatMessageReceivedNotification;
		[Static]
		[Export("ChatMessageReceivedNotification")]
		string ChatMessageReceivedNotification { get; }
	}

	// @interface ChatProvidersSDK_Swift_3873 (ZDKPushNotificationsProvider)
	[Category]
	[BaseType(typeof(ZDKPushNotificationsProvider))]
	interface ZDKPushNotificationsProvider_ChatProvidersSDK_Swift_3873
	{
		// -(void)unregisterPushToken;
		[Export("unregisterPushToken")]
		void UnregisterPushToken();
	}

	// @interface ChatProvidersSDK_Swift_3879 (ZDKPushNotificationsProvider)
	[Category]
	[BaseType(typeof(ZDKPushNotificationsProvider))]
	interface ZDKPushNotificationsProvider_ChatProvidersSDK_Swift_3879
	{
		// -(void)didReceiveRemoteNotification:(NSDictionary * _Nonnull)userInfo in:(UIApplication * _Nonnull)application;
		[Export("didReceiveRemoteNotification:in:")]
		void DidReceiveRemoteNotification(NSDictionary userInfo, UIApplication application);

		// -(BOOL)isChatPushNotification:(NSDictionary * _Nonnull)userInfo __attribute__((warn_unused_result("")));
		[Export("isChatPushNotification:")]
		bool IsChatPushNotification(NSDictionary userInfo);
	}

	// @interface ChatProvidersSDK_Swift_3902 (ZDKPushNotificationsProvider)
	[Category]
	[BaseType(typeof(ZDKPushNotificationsProvider))]
	interface ZDKPushNotificationsProvider_ChatProvidersSDK_Swift_3902
	{
		// -(void)registerPushToken:(NSData * _Nonnull)pushToken;
		[Export("registerPushToken:")]
		void RegisterPushToken(NSData pushToken);
	}

	// @interface ZDKQueuePosition : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKQueuePosition
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (nonatomic) NSInteger queue;
		[Export("queue")]
		nint Queue { get; set; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
	}

	// @interface ZDKSettingsProvider : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKSettingsProvider
	{
		// @property (readonly, nonatomic, strong) ZDKChatSettings * _Nonnull settings;
		[Export("settings", ArgumentSemantic.Strong)]
		ZDKChatSettings Settings { get; }

		// -(ZDKObservationToken * _Nonnull)observeChatSettings:(void (^ _Nonnull)(ZDKChatSettings * _Nonnull))completion __attribute__((warn_unused_result("")));
		[Export("observeChatSettings:")]
		ZDKObservationToken ObserveChatSettings(Action<ZDKChatSettings> completion);
	}

	// @interface ZDKVisitorInfo : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKVisitorInfo
	{
		// @property (readonly, nonatomic, strong, class) ZDKVisitorInfo * _Nonnull initial;
		[Static]
		[Export("initial", ArgumentSemantic.Strong)]
		ZDKVisitorInfo Initial { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull email;
		[Export("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull phoneNumber;
		[Export("phoneNumber")]
		string PhoneNumber { get; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name email:(NSString * _Nonnull)email phoneNumber:(NSString * _Nonnull)phoneNumber;
		[Export("initWithName:email:phoneNumber:")]
		IntPtr Constructor(string name, string email, string phoneNumber);

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	// @interface ZDKVisitorPath : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKVisitorPath
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
		[Export("title")]
		string Title { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull url;
		[Export("url")]
		string Url { get; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title url:(NSString * _Nonnull)url __attribute__((objc_designated_initializer));
		[Export("initWithTitle:url:")]
		[DesignatedInitializer]
		IntPtr Constructor(string title, string url);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }
	}

	// @interface ChatProvidersSDK_Swift_4004 (ZDKVisitorPath)
	[Category]
	[BaseType(typeof(ZDKVisitorPath))]
	interface ZDKVisitorPath_ChatProvidersSDK_Swift_4004
	{
		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
	}
}


namespace MessagingSDKBinding
{
	// @interface ZDKMessaging : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKMessaging
	{
		// @property (readonly, nonatomic, strong, class) ZDKMessaging * _Nonnull instance;
		[Static]
		[Export("instance", ArgumentSemantic.Strong)]
		ZDKMessaging Instance { get; }

		// @property (readonly, nonatomic) BOOL isMessagingPresented;
		[Export("isMessagingPresented")]
		bool IsMessagingPresented { get; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		IZDKMessagingDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ZDKMessagingDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(UIViewController * _Nullable)buildUIWithEngines:(NSArray<id<ZDKEngine>> * _Nonnull)engines configs:(NSArray<id<ZDKConfiguration>> * _Nonnull)configs error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Export("buildUIWithEngines:configs:error:")]
		[return: NullAllowed]
		UIViewController BuildUIWithEngines(ZDKChatEngine[] engines, ZDKMessagingConfiguration[] configs, [NullAllowed] out NSError error);
	}

	[Protocol]
	interface ZDKEngine { }

	interface IZDKConfiguration { }

	[Protocol]
	interface ZDKConfiguration
	{

	}
	//// @interface MessagingSDK_Swift_892 (ZDKMessaging)
	//[Category]
	//[BaseType(typeof(ZDKMessaging))]
	//interface ZDKMessaging_MessagingSDK_Swift_892
	//{
	//	// -(UIViewController * _Nullable)buildUIWithEngines:(NSArray<id<ZDKEngine>> * _Nonnull)engines configs:(NSArray<id<ZDKConfiguration>> * _Nonnull)configs error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
	//	[Export("buildUIWithEngines:configs:error:")]
	//	[return: NullAllowed]
	//	UIViewController BuildUIWithEngines(ZDKEngine[] engines, ZDKConfiguration[] configs, [NullAllowed] out NSError error);
	//}

	// @interface ZDKMessagingConfiguration : NSObject <ZDKConfiguration>
	[BaseType(typeof(NSObject))]
	interface ZDKMessagingConfiguration : IZDKConfiguration
	{
		// @property (copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; set; }

		// @property (nonatomic, strong) UIImage * _Nonnull botAvatar;
		[Export("botAvatar", ArgumentSemantic.Strong)]
		UIImage BotAvatar { get; set; }
	}

	// @protocol ZDKMessagingDelegate
	[Protocol, Model(AutoGeneratedName = true)]
	interface ZDKMessagingDelegate
	{
		// @required -(void)messaging:(ZDKMessaging * _Nonnull)messaging didPerformEvent:(enum ZDKMessagingUIEvent)event context:(id _Nullable)context;
		[Abstract]
		[Export("messaging:didPerformEvent:context:")]
		void Messaging(ZDKMessaging messaging, ZDKMessagingUIEvent @event, [NullAllowed] NSObject context);

		// @required -(BOOL)messaging:(ZDKMessaging * _Nonnull)messaging shouldOpenURL:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
		[Abstract]
		[Export("messaging:shouldOpenURL:")]
		bool Messaging(ZDKMessaging messaging, NSUrl url);
	}
	interface IZDKMessagingDelegate { }
}


namespace ChatSDKBinding
{
	// @interface ZDKChatConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	interface ZDKChatConfiguration
	{
		// @property (nonatomic, strong) ZDKChatFormConfiguration * _Nonnull preChatFormConfiguration;
		[Export("preChatFormConfiguration", ArgumentSemantic.Strong)]
		ZDKChatFormConfiguration PreChatFormConfiguration { get; set; }

		// @property (nonatomic) BOOL isChatTranscriptPromptEnabled;
		[Export("isChatTranscriptPromptEnabled")]
		bool IsChatTranscriptPromptEnabled { get; set; }

		// @property (nonatomic) BOOL isPreChatFormEnabled;
		[Export("isPreChatFormEnabled")]
		bool IsPreChatFormEnabled { get; set; }

		// @property (nonatomic) BOOL isOfflineFormEnabled;
		[Export("isOfflineFormEnabled")]
		bool IsOfflineFormEnabled { get; set; }

		// @property (nonatomic) BOOL isAgentAvailabilityEnabled;
		[Export("isAgentAvailabilityEnabled")]
		bool IsAgentAvailabilityEnabled { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }

		// -(void)setChatMenuActions:(NSArray<NSNumber *> * _Nonnull)actions;
		[Export("setChatMenuActions:")]
		void SetChatMenuActions(NSNumber[] actions);

		// @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull menuActions;
		[Export("menuActions", ArgumentSemantic.Copy)]
		NSNumber[] MenuActions { get; }

	}

	// @interface ChatSDK_Swift_948 (ZDKChatConfiguration)
	[Category]
	[BaseType(typeof(ZDKChatConfiguration))]
	interface ZDKChatConfiguration_ChatSDK_Swift_948
	{
		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
	}

	// @interface ChatSDK_Swift_953 (ZDKChatConfiguration)
	[Category]
	[BaseType(typeof(ZDKChatConfiguration))]
	interface ZDKChatConfiguration_ChatSDK_Swift_953
	{
		//// -(void)setChatMenuActions:(NSArray<NSNumber *> * _Nonnull)actions;
		//[Export ("setChatMenuActions:")]
		//void SetChatMenuActions (NSNumber[] actions);

		//// @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull menuActions;
		//[Export ("menuActions", ArgumentSemantic.Copy)]
		//NSNumber[] MenuActions { get; }
	}

	// @interface ZDKChatEngine : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKChatEngine
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export("id")]
		string Id { get; }

		// @property (readonly, nonatomic, strong) ZDKChatConfiguration * _Nonnull configuration;
		[Export("configuration", ArgumentSemantic.Strong)]
		ZDKChatConfiguration Configuration { get; }

		// -(BOOL)isConversationOngoing __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use isConversationOngoing(_ completion: @escaping (Bool) -> Void) instead")));
		//[Export ("isConversationOngoing")]
		////[Verify (MethodToProperty)]
		//bool IsConversationOngoing { get; }

		// -(void)isConversationOngoing:(void (^ _Nonnull)(BOOL))completion;
		[Export("isConversationOngoing:")]
		void IsConversationOngoing(Action<bool> completion);

		// +(ZDKChatEngine * _Nullable)engineAndReturnError:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Static]
		[Export("engineAndReturnError:")]
		[return: NullAllowed]
		ZDKChatEngine EngineAndReturnError([NullAllowed] out NSError error);
	}

	// @interface ZDKChatFormConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKChatFormConfiguration
	{
		// @property (nonatomic) enum ZDKFormFieldStatus name;
		[Export("name", ArgumentSemantic.Assign)]
		ZDKFormFieldStatus Name { get; set; }

		// @property (nonatomic) enum ZDKFormFieldStatus email;
		[Export("email", ArgumentSemantic.Assign)]
		ZDKFormFieldStatus Email { get; set; }

		// @property (nonatomic) enum ZDKFormFieldStatus phoneNumber;
		[Export("phoneNumber", ArgumentSemantic.Assign)]
		ZDKFormFieldStatus PhoneNumber { get; set; }

		// @property (nonatomic) enum ZDKFormFieldStatus department;
		[Export("department", ArgumentSemantic.Assign)]
		ZDKFormFieldStatus Department { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export("debugDescription")]
		string DebugDescription { get; }

		// -(instancetype _Nonnull)initWithName:(enum ZDKFormFieldStatus)name email:(enum ZDKFormFieldStatus)email phoneNumber:(enum ZDKFormFieldStatus)phoneNumber department:(enum ZDKFormFieldStatus)department __attribute__((objc_designated_initializer));
		[Export("initWithName:email:phoneNumber:department:")]
		[DesignatedInitializer]
		IntPtr Constructor(ZDKFormFieldStatus name, ZDKFormFieldStatus email, ZDKFormFieldStatus phoneNumber, ZDKFormFieldStatus department);

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("isEqual:")]
		bool IsEqual([NullAllowed] NSObject @object);
	}
}
