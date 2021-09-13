using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

using GroupMeClientApi;
using GroupMeClientApi.Models;

using Minecraftchest1;

namespace groupmeCLI
{
	class Program
	{
		static void Main()
		{
			var _menu = new Dictionary<byte, string>()
			{
				{1, "Login/Change User"},
				{2, "List groups"},
				{3, "List Direct Messages"},
				{4, "Who am I"},
				{0, "Exit"}
			};

			byte _response = Utils.Menu(_menu);
			switch (_response) 
			{
				case 0:
					Utils.Exit();
					break;
				case 1:
					_account();
					break;
				case 2:
					_groups().Wait();
					break;
				case 3:
					_dm();
					break;
				case 4:
					_whoami();
					break;
				default:
					Console.WriteLine("Unknown Option");
					break;
			}
		}
		static void _whoami()
		{
			Console.WriteLine("Whoami\n----------");
			string _token = _getToken();
			GroupMeClientApi.GroupMeClient _client = new GroupMeClientApi.GroupMeClient(_token);
			Console.WriteLine(_client.WhoAmI().Name);
		}
		static string _getToken()
		{
			string _homedir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			string _path = _homedir + @"/.GroupmeCli.json";
			
			var _json =  File.ReadAllText(_path);
			User _user = JsonSerializer.Deserialize<User>(_json);
			return _user.token;
		}
		static void _account()
		{
			string _homedir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			string _path = _homedir + @"/.GroupmeCli.json";

			Console.WriteLine("Creating test document.");
			User _user = new User();


			_user.token = Utils.Input("Please enter Groupme personal access token: ");
			//string _oauthId;
			/*
			GroupMeClientApi.OAuthClient _oauthClient = 
				new GroupMeClientApi.OAuthClient("Groupme CLI",_oauthId);
			Console.WriteLine("Oauth url is: ", _oauthClient.GroupMeOAuthUrl);
			*/

			string _json = JsonSerializer.Serialize(_user);
			File.WriteAllText(_path, _json);
		}
		static async Task _groups()
		{
			Console.WriteLine("Chats");
			string _token = _getToken();
			Console.WriteLine("Token: ********************", _token);
			Console.WriteLine();
			GroupMeClientApi.GroupMeClient _client = new GroupMeClientApi.GroupMeClient(_token);

			await _client.GetGroupsAsync();
			await _client.GetChatsAsync();
			await _client.GetContactsAsync();

			foreach (IMessageContainer _messageContainer in _client.Groups())
			{
				Console.WriteLine("{0} - {1}", _messageContainer.Name, _messageContainer.LatestMessage.Text.ToString());
			}
		}
		static void _dm()
		{
			Console.WriteLine("This is where direct messages will go.");
		}
	}
	[Serializable]
	public class User
	{
		public string token {get; set;}
	}
}
