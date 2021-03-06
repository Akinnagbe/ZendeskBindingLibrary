using System;
using Foundation;
using ObjCRuntime;
using ZendeskCoreSDK;

namespace Binding
{
	// @interface ZDKCoreLogger : NSObject
	[BaseType (typeof(NSObject))]
	interface ZDKCoreLogger
	{
		// @property (nonatomic, class) enum ZDKLogLevel logLevel;
		[Static]
		[Export ("logLevel", ArgumentSemantic.Assign)]
		ZDKLogLevel LogLevel { get; set; }

		// @property (nonatomic, class) BOOL enabled;
		[Static]
		[Export ("enabled")]
		bool Enabled { get; set; }

		// +(void)error:(NSString * _Nonnull)message;
		[Static]
		[Export ("error:")]
		void Error (string message);

		// +(void)warn:(NSString * _Nonnull)message;
		[Static]
		[Export ("warn:")]
		void Warn (string message);

		// +(void)info:(NSString * _Nonnull)message;
		[Static]
		[Export ("info:")]
		void Info (string message);

		// +(void)debug:(NSString * _Nonnull)message;
		[Static]
		[Export ("debug:")]
		void Debug (string message);

		// +(void)verbose:(NSString * _Nonnull)message;
		[Static]
		[Export ("verbose:")]
		void Verbose (string message);
	}

	// @interface ZDKHelpCenterUtil : NSObject
	[BaseType (typeof(NSObject))]
	interface ZDKHelpCenterUtil
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nullable zendeskURL;
		[Static]
		[NullAllowed, Export ("zendeskURL")]
		string ZendeskURL { get; }

		// @property (readonly, nonatomic, class) BOOL hasAuth;
		[Static]
		[Export ("hasAuth")]
		bool HasAuth { get; }

		// +(NSURLRequest * _Nonnull)canonicalRequestFor:(NSURLRequest * _Nonnull)request __attribute__((warn_unused_result("")));
		[Static]
		[Export ("canonicalRequestFor:")]
		NSUrlRequest CanonicalRequestFor (NSUrlRequest request);
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
*/[Protocol (Name = "_TtP14ZendeskCoreSDK17IdentityMigration_")]
	[BaseType (typeof(NSObject), Name = "_TtP14ZendeskCoreSDK17IdentityMigration_")]
	interface IdentityMigration
	{
		// @required -(NSString * _Nullable)getMigratedAnonymousName __attribute__((warn_unused_result("")));
		[Abstract]
		[NullAllowed, Export ("getMigratedAnonymousName")]
		//[Verify (MethodToProperty)]
		string MigratedAnonymousName { get; }

		// @required -(NSString * _Nullable)getMigratedAnonymousEmail __attribute__((warn_unused_result("")));
		[Abstract]
		[NullAllowed, Export ("getMigratedAnonymousEmail")]
		//[Verify (MethodToProperty)]
		string MigratedAnonymousEmail { get; }

		// @required -(NSString * _Nullable)getMigratedJwtIdentifier __attribute__((warn_unused_result("")));
		[Abstract]
		[NullAllowed, Export ("getMigratedJwtIdentifier")]
		//[Verify (MethodToProperty)]
		string MigratedJwtIdentifier { get; }
	}

	// @interface ZDKUser : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKUser
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull content_url;
		[Export ("content_url")]
		string Content_url { get; }

		// @property (readonly, nonatomic) BOOL agent;
		[Export ("agent")]
		bool Agent { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull tags;
		[Export ("tags", ArgumentSemantic.Copy)]
		string[] Tags { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull user_fields;
		[Export ("user_fields", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> User_fields { get; }
	}

	// @interface ZDKUserField : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKUserField
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull url;
		[Export ("url")]
		string Url { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull key;
		[Export ("key")]
		string Key { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull fieldType;
		[Export ("fieldType")]
		string FieldType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull raw_title;
		[Export ("raw_title")]
		string Raw_title { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull fieldDescription;
		[Export ("fieldDescription")]
		string FieldDescription { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull raw_description;
		[Export ("raw_description")]
		string Raw_description { get; }

		// @property (readonly, nonatomic) NSInteger position;
		[Export ("position")]
		nint Position { get; }

		// @property (readonly, nonatomic) BOOL active;
		[Export ("active")]
		bool Active { get; }

		// @property (readonly, nonatomic) BOOL system;
		[Export ("system")]
		bool System { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull regexp_for_validation;
		[Export ("regexp_for_validation")]
		string Regexp_for_validation { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull created_at;
		[Export ("created_at", ArgumentSemantic.Copy)]
		NSDate Created_at { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull updated_at;
		[Export ("updated_at", ArgumentSemantic.Copy)]
		NSDate Updated_at { get; }

		// @property (readonly, copy, nonatomic) NSArray<ZDKUserFieldOption *> * _Nullable custom_field_options;
		[NullAllowed, Export ("custom_field_options", ArgumentSemantic.Copy)]
		ZDKUserFieldOption[] Custom_field_options { get; }
	}

	// @interface ZDKUserFieldOption : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKUserFieldOption
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic) NSInteger position;
		[Export ("position")]
		nint Position { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull raw_name;
		[Export ("raw_name")]
		string Raw_name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull url;
		[Export ("url")]
		string Url { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull value;
		[Export ("value")]
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
*/[Protocol (Name = "_TtP14ZendeskCoreSDK15ZDKObjCIdentity_")]
	interface ZDKObjCIdentity
	{
	}

	// @interface ZDKObjCAnonymous : NSObject <ZDKObjCIdentity>
	[BaseType (typeof(NSObject), Name = "_TtC14ZendeskCoreSDK16ZDKObjCAnonymous")]
	[DisableDefaultCtor]
	interface ZDKObjCAnonymous : IZDKObjCIdentity
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable guid;
		[NullAllowed, Export ("guid")]
		string Guid { get; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nullable)name email:(NSString * _Nullable)email __attribute__((objc_designated_initializer));
		[Export ("initWithName:email:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] string name, [NullAllowed] string email);
	}

	// @interface ZDKObjCJwt : NSObject <ZDKObjCIdentity>
	[BaseType (typeof(NSObject), Name = "_TtC14ZendeskCoreSDK10ZDKObjCJwt")]
	[DisableDefaultCtor]
	interface ZDKObjCJwt : ZDKObjCIdentity
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull token;
		[Export ("token")]
		string Token { get; }

		// -(instancetype _Nonnull)initWithToken:(NSString * _Nonnull)token __attribute__((objc_designated_initializer));
		[Export ("initWithToken:")]
		[DesignatedInitializer]
		IntPtr Constructor (string token);
	}

	// @interface ZDKPushProvider : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14ZendeskCoreSDK15ZDKPushProvider")]
	[DisableDefaultCtor]
	interface ZDKPushProvider
	{
		// -(instancetype _Nonnull)initWithZendesk:(ZDKZendesk * _Nonnull)zendesk __attribute__((objc_designated_initializer));
		[Export ("initWithZendesk:")]
		[DesignatedInitializer]
		IntPtr Constructor (ZDKZendesk zendesk);

		// -(void)registerWithDeviceIdentifier:(NSString * _Nonnull)deviceIdentifier locale:(NSString * _Nonnull)locale completion:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
		[Export ("registerWithDeviceIdentifier:locale:completion:")]
		void RegisterWithDeviceIdentifier (string deviceIdentifier, string locale, Action<NSString, NSError> completion);

		// -(void)registerWithUAIdentifier:(NSString * _Nonnull)UAIdentifier locale:(NSString * _Nonnull)locale completion:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
		[Export ("registerWithUAIdentifier:locale:completion:")]
		void RegisterWithUAIdentifier (string UAIdentifier, string locale, Action<NSString, NSError> completion);

		// -(void)unregisterForPush;
		[Export ("unregisterForPush")]
		void UnregisterForPush ();
	}

	// @interface ZDKUserProvider : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14ZendeskCoreSDK15ZDKUserProvider")]
	[DisableDefaultCtor]
	interface ZDKUserProvider
	{
		// -(instancetype _Nonnull)initWithZendesk:(ZDKZendesk * _Nonnull)zendesk __attribute__((objc_designated_initializer));
		[Export ("initWithZendesk:")]
		[DesignatedInitializer]
		IntPtr Constructor (ZDKZendesk zendesk);

		// -(void)getUserWithCompletion:(void (^ _Nonnull)(ZDKUser * _Nullable, NSError * _Nullable))completion;
		[Export ("getUserWithCompletion:")]
		void GetUserWithCompletion (Action<ZDKUser, NSError> completion);

		// -(void)setUserFields:(NSDictionary<NSString *,id> * _Nonnull)userFields completion:(void (^ _Nonnull)(ZDKUser * _Nullable, NSError * _Nullable))completion;
		[Export ("setUserFields:completion:")]
		void SetUserFields (NSDictionary<NSString, NSObject> userFields, Action<ZDKUser, NSError> completion);

		// -(void)getUserFieldsWithCompletion:(void (^ _Nonnull)(NSArray<ZDKUserField *> * _Nonnull, NSError * _Nullable))completion;
		[Export ("getUserFieldsWithCompletion:")]
		void GetUserFieldsWithCompletion (Action<NSArray<ZDKUserField>, NSError> completion);

		// -(void)addTags:(NSArray<NSString *> * _Nonnull)tags :(void (^ _Nonnull)(NSArray<NSString *> * _Nonnull, NSError * _Nullable))completion;
		[Export ("addTags::")]
		void AddTags (string[] tags, Action<NSArray<NSString>, NSError> completion);

		// -(void)deleteTags:(NSArray<NSString *> * _Nonnull)tags completion:(void (^ _Nonnull)(NSArray<NSString *> * _Nonnull, NSError * _Nullable))completion;
		[Export ("deleteTags:completion:")]
		void DeleteTags (string[] tags, Action<NSArray<NSString>, NSError> completion);
	}

	// @interface ZDKZendesk : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ZDKZendesk
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull zendeskUrl;
		[Export ("zendeskUrl")]
		string ZendeskUrl { get; }

		// +(void)initializeWithAppId:(NSString * _Nonnull)appId clientId:(NSString * _Nonnull)clientId zendeskUrl:(NSString * _Nonnull)zendeskUrl;
		[Static]
		[Export ("initializeWithAppId:clientId:zendeskUrl:")]
		void InitializeWithAppId (string appId, string clientId, string zendeskUrl);
	}

	// @interface ZendeskCoreSDK_Swift_1556 (ZDKZendesk)
	[Category]
	[BaseType (typeof(ZDKZendesk))]
	interface ZDKZendesk_ZendeskCoreSDK_Swift_1556
	{
		// @property (readonly, nonatomic, strong, class) ZDKZendesk * _Nullable instance;
		[Static]
		[NullAllowed, Export ("instance", ArgumentSemantic.Strong)]
		ZDKZendesk Instance { get; }

		// -(void)setIdentity:(id<ZDKObjCIdentity> _Nonnull)newIdentity;
		[Export ("setIdentity:")]
		void SetIdentity (ZDKObjCIdentity newIdentity);

		// -(id<ZDKObjCIdentity> _Nullable)objCIdentity __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("objCIdentity")]
		//[Verify (MethodToProperty)]
		ZDKObjCIdentity ObjCIdentity { get; }
	}
}
