﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace RachelleTanaseTestSuite
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the RachelleTanaseTestSuiteRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.0")]
    [RepositoryFolder("7e9d0a99-0e95-42fb-8656-41df3cf02481")]
    public partial class RachelleTanaseTestSuiteRepository : RepoGenBaseFolder
    {
        static RachelleTanaseTestSuiteRepository instance = new RachelleTanaseTestSuiteRepository();
        RachelleTanaseTestSuiteRepositoryFolders.SalesforceComCustomerSecureLoginPAppFolder _salesforcecomcustomersecureloginp;
        RachelleTanaseTestSuiteRepositoryFolders.DropdownAppFolder _dropdown;

        /// <summary>
        /// Gets the singleton class instance representing the RachelleTanaseTestSuiteRepository element repository.
        /// </summary>
        [RepositoryFolder("7e9d0a99-0e95-42fb-8656-41df3cf02481")]
        public static RachelleTanaseTestSuiteRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public RachelleTanaseTestSuiteRepository() 
            : base("RachelleTanaseTestSuiteRepository", "/", null, 0, false, "7e9d0a99-0e95-42fb-8656-41df3cf02481", ".\\RepositoryImages\\RachelleTanaseTestSuiteRepository7e9d0a99.rximgres")
        {
            _salesforcecomcustomersecureloginp = new RachelleTanaseTestSuiteRepositoryFolders.SalesforceComCustomerSecureLoginPAppFolder(this);
            _dropdown = new RachelleTanaseTestSuiteRepositoryFolders.DropdownAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("7e9d0a99-0e95-42fb-8656-41df3cf02481")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The SalesforceComCustomerSecureLoginP folder.
        /// </summary>
        [RepositoryFolder("b46953b9-c7a1-4d97-a4c2-5b862c82f821")]
        public virtual RachelleTanaseTestSuiteRepositoryFolders.SalesforceComCustomerSecureLoginPAppFolder SalesforceComCustomerSecureLoginP
        {
            get { return _salesforcecomcustomersecureloginp; }
        }

        /// <summary>
        /// The Dropdown folder.
        /// </summary>
        [RepositoryFolder("558574c2-3a01-4159-9292-2863d6440bc7")]
        public virtual RachelleTanaseTestSuiteRepositoryFolders.DropdownAppFolder Dropdown
        {
            get { return _dropdown; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.0")]
    public partial class RachelleTanaseTestSuiteRepositoryFolders
    {
        /// <summary>
        /// The SalesforceComCustomerSecureLoginPAppFolder folder.
        /// </summary>
        [RepositoryFolder("b46953b9-c7a1-4d97-a4c2-5b862c82f821")]
        public partial class SalesforceComCustomerSecureLoginPAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _usernameInfo;
            RepoItemInfo _loginInfo;
            RepoItemInfo _myaccountstabInfo;
            RepoItemInfo _recordacallInfo;
            RepoItemInfo _itargetInfo;
            RepoItemInfo _hometabInfo;
            RepoItemInfo _usernavarrowInfo;
            RepoItemInfo _logoutInfo;

            /// <summary>
            /// Creates a new SalesforceComCustomerSecureLoginP  folder.
            /// </summary>
            public SalesforceComCustomerSecureLoginPAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SalesforceComCustomerSecureLoginP", "/dom[17]", parentFolder, 30000, null, false, "b46953b9-c7a1-4d97-a4c2-5b862c82f821", "")
            {
                _usernameInfo = new RepoItemInfo(this, "Username", ".//input[#'username']", 30000, null, "e201e2e3-f38b-4938-93bc-34f29a3ec6e5");
                _loginInfo = new RepoItemInfo(this, "Login", ".//button[#'Login']", 30000, null, "85978a88-164a-41e9-9012-4cba1a3971c6");
                _myaccountstabInfo = new RepoItemInfo(this, "MyAccountsTab", ".//li[#'01rU0000000YP6A_Tab']/a[@innertext='My Accounts']", 30000, null, "9d7b2e17-1201-4fb3-a028-27669f23ae33");
                _recordacallInfo = new RepoItemInfo(this, "RecordACall", ".//td[#'topButtonRow']/input[@title='Record a Call']", 30000, null, "f7e14386-d9f6-4605-b15a-dd36cd5f6a30");
                _itargetInfo = new RepoItemInfo(this, "Itarget", ".//iframe[#'itarget']", 30000, null, "20808d26-2c41-443e-8459-47eb4764a4be");
                _hometabInfo = new RepoItemInfo(this, "HomeTab", ".//li[#'home_Tab']/a[@innertext='Home']", 30000, null, "93e31dad-d47e-44a8-b2a2-bed4e5cf9fa9");
                _usernavarrowInfo = new RepoItemInfo(this, "UserNavArrow", ".//div[#'userNav-arrow']", 30000, null, "b270b1a1-3366-4493-b93a-0c332d816f87");
                _logoutInfo = new RepoItemInfo(this, "Logout", ".//div[#'userNav-menuItems']/a[@innertext='Logout']", 30000, null, "a9df9dd2-a168-48b3-b308-aa1d4b1a50b9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b46953b9-c7a1-4d97-a4c2-5b862c82f821")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b46953b9-c7a1-4d97-a4c2-5b862c82f821")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Username item.
            /// </summary>
            [RepositoryItem("e201e2e3-f38b-4938-93bc-34f29a3ec6e5")]
            public virtual Ranorex.InputTag Username
            {
                get
                {
                    return _usernameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Username item info.
            /// </summary>
            [RepositoryItemInfo("e201e2e3-f38b-4938-93bc-34f29a3ec6e5")]
            public virtual RepoItemInfo UsernameInfo
            {
                get
                {
                    return _usernameInfo;
                }
            }

            /// <summary>
            /// The Login item.
            /// </summary>
            [RepositoryItem("85978a88-164a-41e9-9012-4cba1a3971c6")]
            public virtual Ranorex.ButtonTag Login
            {
                get
                {
                    return _loginInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The Login item info.
            /// </summary>
            [RepositoryItemInfo("85978a88-164a-41e9-9012-4cba1a3971c6")]
            public virtual RepoItemInfo LoginInfo
            {
                get
                {
                    return _loginInfo;
                }
            }

            /// <summary>
            /// The MyAccountsTab item.
            /// </summary>
            [RepositoryItem("9d7b2e17-1201-4fb3-a028-27669f23ae33")]
            public virtual Ranorex.ATag MyAccountsTab
            {
                get
                {
                    return _myaccountstabInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The MyAccountsTab item info.
            /// </summary>
            [RepositoryItemInfo("9d7b2e17-1201-4fb3-a028-27669f23ae33")]
            public virtual RepoItemInfo MyAccountsTabInfo
            {
                get
                {
                    return _myaccountstabInfo;
                }
            }

            /// <summary>
            /// The RecordACall item.
            /// </summary>
            [RepositoryItem("f7e14386-d9f6-4605-b15a-dd36cd5f6a30")]
            public virtual Ranorex.InputTag RecordACall
            {
                get
                {
                    return _recordacallInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The RecordACall item info.
            /// </summary>
            [RepositoryItemInfo("f7e14386-d9f6-4605-b15a-dd36cd5f6a30")]
            public virtual RepoItemInfo RecordACallInfo
            {
                get
                {
                    return _recordacallInfo;
                }
            }

            /// <summary>
            /// The Itarget item.
            /// </summary>
            [RepositoryItem("20808d26-2c41-443e-8459-47eb4764a4be")]
            public virtual Ranorex.IFrameTag Itarget
            {
                get
                {
                    return _itargetInfo.CreateAdapter<Ranorex.IFrameTag>(true);
                }
            }

            /// <summary>
            /// The Itarget item info.
            /// </summary>
            [RepositoryItemInfo("20808d26-2c41-443e-8459-47eb4764a4be")]
            public virtual RepoItemInfo ItargetInfo
            {
                get
                {
                    return _itargetInfo;
                }
            }

            /// <summary>
            /// The HomeTab item.
            /// </summary>
            [RepositoryItem("93e31dad-d47e-44a8-b2a2-bed4e5cf9fa9")]
            public virtual Ranorex.ATag HomeTab
            {
                get
                {
                    return _hometabInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The HomeTab item info.
            /// </summary>
            [RepositoryItemInfo("93e31dad-d47e-44a8-b2a2-bed4e5cf9fa9")]
            public virtual RepoItemInfo HomeTabInfo
            {
                get
                {
                    return _hometabInfo;
                }
            }

            /// <summary>
            /// The UserNavArrow item.
            /// </summary>
            [RepositoryItem("b270b1a1-3366-4493-b93a-0c332d816f87")]
            public virtual Ranorex.DivTag UserNavArrow
            {
                get
                {
                    return _usernavarrowInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The UserNavArrow item info.
            /// </summary>
            [RepositoryItemInfo("b270b1a1-3366-4493-b93a-0c332d816f87")]
            public virtual RepoItemInfo UserNavArrowInfo
            {
                get
                {
                    return _usernavarrowInfo;
                }
            }

            /// <summary>
            /// The Logout item.
            /// </summary>
            [RepositoryItem("a9df9dd2-a168-48b3-b308-aa1d4b1a50b9")]
            public virtual Ranorex.ATag Logout
            {
                get
                {
                    return _logoutInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Logout item info.
            /// </summary>
            [RepositoryItemInfo("a9df9dd2-a168-48b3-b308-aa1d4b1a50b9")]
            public virtual RepoItemInfo LogoutInfo
            {
                get
                {
                    return _logoutInfo;
                }
            }
        }

        /// <summary>
        /// The DropdownAppFolder folder.
        /// </summary>
        [RepositoryFolder("558574c2-3a01-4159-9292-2863d6440bc7")]
        public partial class DropdownAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new Dropdown  folder.
            /// </summary>
            public DropdownAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Dropdown", "/container[@caption='dropdown']", parentFolder, 30000, null, true, "558574c2-3a01-4159-9292-2863d6440bc7", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("558574c2-3a01-4159-9292-2863d6440bc7")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("558574c2-3a01-4159-9292-2863d6440bc7")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}