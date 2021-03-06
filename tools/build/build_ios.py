#coding:utf-8
import sys
reload(sys)
sys.setdefaultencoding("utf-8")
import traceback
import os
import shutil
import platform

def export(unity_path,project_path,common_path,medata_path,export_path,log_path,app_name,app_bundle_id,app_bundle_ver,app_teamid,app_debug):
    app_ipa_name = app_bundle_id.split('.')[2];
    mode = "Release"
    shutil.copy(common_path + "/dll/NGUI-No-Editor/NGUI.dll",project_path + "/Assets/Plugins/NGUI.dll");
    shutil.copy(common_path + "/gbdll/ios/GameBase.dll",project_path + "/Assets/Plugins/GameBase.dll");
    if(os.path.exists(project_path + "/Assets/Code/External/NGUI/Scripts/Editor")):
        shutil.rmtree(project_path + "/Assets/Code/External/NGUI/Scripts/Editor");
    if(os.path.exists(project_path + "/Assets/StreamingAssets/MeData")):
        shutil.rmtree(project_path + "/Assets/StreamingAssets/MeData");
    shutil.copytree(medata_path,project_path + "/Assets/StreamingAssets/MeData");
    
    command = []
    command.append(unity_path)
    command.append(" -batchmode")
    command.append(" -quit")
    command.append(" -projectPath " + project_path)
    command.append(" -logFile " + log_path)
    command.append(" -nographics") 
    command.append(" -executeMethod GameCore.ExportXcode.Export")
    command.append(" " + app_name)
    command.append(" " + app_bundle_id)
    command.append(" " + app_bundle_ver)
    command.append(" " + app_teamid)
    command.append(" " + export_path)
    command.append(" ICONPATH")
    command.append(" SPLASHPATH")
    command.append(" " + app_debug)
    print(u"starting unity,export xcode project...")
    command = ''.join(command)
    if(platform.system().lower() == "darwin"):
        os.system(command);
        print(u"build archive...");
        os.chdir(export_path)
        os.system("chmod +x ./MapFileParser.sh")
        command = []
        command.append("xcodebuild")
        command.append(" archive")
        command.append(" -scheme Unity-iPhone")
        command.append(" -configuration " + mode)
        command.append(" -archivePath ./build/Release-iphoneos/" + app_ipa_name + ".xcarchive")
        command.append(" -quiet>>" + log_path)
        command = ''.join(command)
        os.system(command);
        print(u"export ipa...");
        command = []
        command.append("xcodebuild")
        command.append(" -exportArchive")
        command.append(" -archivePath ./build/Release-iphoneos/" + app_ipa_name + ".xcarchive")
        command.append(" -configuration " + mode)
        command.append(" -exportPath ~/Desktop")
        command.append(" -exportOptionsPlist " + sys.path[0] + "/export.plist")
        command.append(" -quiet>>" + log_path)
        command = ''.join(command)
        os.system(command);
    else:
        os.system(command);

if __name__ == "__main__":
    try:
        if(len(sys.argv) >= 12):
            #路径配置
            unity_path =  sys.argv[1]
            project_path = sys.argv[2]
            common_path = sys.argv[3]
            medata_path = sys.argv[4]
            export_path = sys.argv[5]
            log_path = sys.argv[6]
            #应用配置
            app_name = sys.argv[7]
            app_bundle_id = sys.argv[8]
            app_bundle_ver = sys.argv[9]
            app_teamid = sys.argv[10]
            app_debug = sys.argv[11]
            export(unity_path,project_path,common_path,medata_path,export_path,log_path,app_name,app_bundle_id,app_bundle_ver,app_teamid,app_debug)
        else:
            print(u"arg error")
    except:
        traceback.print_exc()
        os.system("pause")