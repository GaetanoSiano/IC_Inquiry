
function onSelectedIndexChanged(s, e) {
    if (profile.GetSelectedIndex() == -1) {
        ShowHideProfileButtons();
        grid.PerformCallback(-1);
    } else {
        ShowHideProfileButtons();
        var lytID = profile.GetSelectedItem().GetColumnText("ID");
        grid.PerformCallback(lytID);
    }

}

function ShowHideProfileButtons() {

    if (profile.GetSelectedIndex() == -1) {
        profile.SetButtonVisible(1, false);
        profile.SetButtonVisible(2, false);
    } else {
        profile.SetButtonVisible(1, true);
        profile.SetButtonVisible(2, true);
    }

}

function onDelete(s, e) {
    if (e.htmlEvent.keyCode == 46) {
        s.SetSelectedIndex(-1);
        grid.PerformCallback(-1);
        s.HideDropDown();
    }
}

function onButtonClick(s, e) {
    var date = profile.GetValue()
    switch (e.buttonIndex) {
        case 0:
            btnUpdate.SetVisible(false);
            btnAdd.SetVisible(true);
            btnDelete.SetVisible(false);
            popup.Show();
            break;
        case 1:
            btnUpdate.SetVisible(true);
            btnAdd.SetVisible(false);
            btnDelete.SetVisible(false);
            layoutName.SetValue(profile.GetSelectedItem().GetColumnText("LayoutName"))

            popup.Show();
            break;
        case 2:
            btnUpdate.SetVisible(false);
            btnAdd.SetVisible(false);
            btnDelete.SetVisible(true);
            layoutName.SetValue(profile.GetSelectedItem().GetColumnText("LayoutName"))
            layoutName.SetEnabled(false);
            popup.Show();
            break;
        case 3:
            alert(3);
    };
}

function UpdateGridHeight() {
    //grid.SetHeight(0);
    //var containerHeight = ASPxClientUtils.GetDocumentClientHeight();
    //if (document.body.scrollHeight > containerHeight)
    //    containerHeight = document.body.scrollHeight;
    //grid.SetHeight(containerHeight  - 10);
    var height = Math.max(0, document.documentElement.clientHeight);
    grid.SetHeight(height - 70);
    var width = Math.max(0, document.documentElement.clientWidth);
    grid.SetWidth(width - 20);
}


function OnMoreInfoClick(contentUrl) {
    //clientPopupControl.SetContentUrl(contentUrl);
    //clientPopupControl.Show();
    window.open(contentUrl, "Info", "width=800,height=800,menubar=no,resizable=yes,scrollbars=yes,titlebar=no,toolbar=no");
}

function onAddClick() {
    popup.Hide();
    // layoutCallback.PerformCallback('ADD');

}

function onUpdateClick() {
    popup.Hide();
    // layoutCallback.PerformCallback('ADD');

}

function onDeleteClick() {
    popup.Hide();
    // layoutCallback.PerformCallback('ADD');

}

function OnToolbarItemClick(s, e) {
    if (IsExportToolbarCommand(e.item.name)) {
        e.processOnServer = true;
        e.usePostBack = true;
    } else {
       // alert("Command not implemented");
        //var index = grid.GetFocusedRowIndex();
        //grid.StartEditRow(index);
        //popPrice.Show();
    }
}
function IsExportToolbarCommand(command) {
    return command === "ExportToPDF" || command === "ExportToXLSX" || command === "ExportToXLS" || command === "ExportToCSV" || command === "ResetLayout" || command === "Print" || command === "Price";
}

function OnMenulick(s, e) {
    var parent = e.item.parent;
    if (e.item.parent.name !== "")
        parent.SetEnabled(false);
}


function OnOrderNoClick(OETYPE, ORDUNIQ, COMPANYID, OPPOID, SID) {

    var isQuote = 0;
    var aspPage = 'OE_OpportunityOrders'

    if (OETYPE == 4) {
        aspPage = 'OE_OpportunityQuotes'
        isQuote = 1;
    }

    var path = '/crm/CustomPages/ACCPAC/' + aspPage + '.asp?F=ACCPAC/' + aspPage + '.asp&J=ACCPAC/' + aspPage + '.asp&SAGEERP_ISQUOTE=' + isQuote + '&APPL=SAGECRM&APPL=SAGEERP&SAGECRM_COMPANYID=' + COMPANYID + '&SAGECRM_OPPOID=' + OPPOID + '&SAGEERP_CUSTOMER=&SAGEERP_DATASET=SRPDAT&SAGEERP_SESSIONID=' + SID + '&SID=' + SID + '&ORDUNIQ=' + ORDUNIQ + '&Key0=1&Key1=' + COMPANYID + '&Key2=&Key7=' + OPPOID + '&OEMODE=2&SAGEERP_EDITMODE=0';
    window.open(path, "_parent");

}