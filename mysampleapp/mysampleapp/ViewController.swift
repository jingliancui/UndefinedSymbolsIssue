//
//  ViewController.swift
//  mysampleapp
//
//  Created by eric cui on 2025/11/21.
//

import UIKit
import AgoraRtcKit

class ViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        AgoraRtcEngineKit.sharedEngine(withAppId: "", delegate: nil)
    }
    

}

