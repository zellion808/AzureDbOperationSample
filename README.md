# AzureDbOperationSample
【Xamarin】AzureMobileAppsのEasy Tablesへのアプリからへの接続、操作のサンプル  
EasyTables以外（自前のSQLDB等）は操作できません

# 手順（備忘録）
1　AzureのSQLサーバ、データベースを作成する（Azureポータル）  
2　MobileAppsを作成する（Azureポータル）  
3　Easy Tablesからテーブルを作成する（Azureポータル）  
4　NuGet パッケージの管理からMicrosoft.Azure.Mobile.Client パッケージをインストールする（2017/06/19時点では最新の4.0.0がインストールできないため3.1.0をインストール、原因は不明）（アプリ）  
5　https://docs.microsoft.com/ja-jp/azure/app-service-mobile/app-service-mobile-dotnet-how-to-use-client-library（Azure Mobile Apps 用の管理されたクライアントの使用方法）を参考にテーブル操作を実行する  
AzureMobileAppのクイックスタート→Xamarin.Forms→新しいアプリの作成→ダウンロードからサンプルアプリがダウンロードできるのでそれも参考にする  
テーブルデータの参照、挿入、更新、削除は上記の方法で実装可能

# 参考URL
https://docs.microsoft.com/ja-jp/azure/app-service-mobile/app-service-mobile-dotnet-how-to-use-client-library
