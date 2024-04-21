import { Component, OnInit } from '@angular/core';
import { UserInfo } from '../model/user-info';

export class NavComponent implements OnInit
{
    userInfo: UserInfo;

    async ngOnInit() {
        this.userInfo = await this.getUserInfo();
    }
    // ...
}