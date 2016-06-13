System.register(['angular2/core', 'rxjs/Rx', './toast/toast.service'], function(exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
        var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
        if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
        else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
        return c > 3 && r && Object.defineProperty(target, key, r), r;
    };
    var __metadata = (this && this.__metadata) || function (k, v) {
        if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
    };
    var core_1, Rx_1, toast_service_1;
    var ExceptionService;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (Rx_1_1) {
                Rx_1 = Rx_1_1;
            },
            function (toast_service_1_1) {
                toast_service_1 = toast_service_1_1;
            }],
        execute: function() {
            ExceptionService = (function () {
                function ExceptionService(_toastService) {
                    var _this = this;
                    this._toastService = _toastService;
                    this.catchBadResponse = function (errorResponse) {
                        var res = errorResponse;
                        var err = res.json();
                        var emsg = err ?
                            (err.error ? err.error : JSON.stringify(err)) :
                            (res.statusText || 'unknown error');
                        _this._toastService.activate("Error - Bad Response - " + emsg);
                        //return Observable.throw(emsg); // TODO: We should NOT swallow error here.
                        return Rx_1.Observable.of();
                    };
                }
                ExceptionService = __decorate([
                    core_1.Injectable(), 
                    __metadata('design:paramtypes', [toast_service_1.ToastService])
                ], ExceptionService);
                return ExceptionService;
            }());
            exports_1("ExceptionService", ExceptionService);
        }
    }
});
//# sourceMappingURL=exception.service.js.map