namespace LLVMSharp
{
    using System;
    using System.Runtime.InteropServices;

    public partial struct LLVMOpaqueMemoryBuffer
    {
    }

    public partial struct LLVMOpaqueContext
    {
    }

    public partial struct LLVMOpaqueModule
    {
    }

    public partial struct LLVMOpaqueType
    {
    }

    public partial struct LLVMOpaqueValue
    {
    }

    public partial struct LLVMOpaqueBasicBlock
    {
    }

    public partial struct LLVMOpaqueBuilder
    {
    }

    public partial struct LLVMOpaqueModuleProvider
    {
    }

    public partial struct LLVMOpaquePassManager
    {
    }

    public partial struct LLVMOpaquePassRegistry
    {
    }

    public partial struct LLVMOpaqueUse
    {
    }

    public partial struct LLVMOpaqueDiagnosticInfo
    {
    }

    public partial struct LLVMOpInfoSymbol1
    {
        public int @Present;
        [MarshalAs(UnmanagedType.LPStr)] public string @Name;
        public int @Value;
    }

    public partial struct LLVMOpInfo1
    {
        public LLVMOpInfoSymbol1 @AddSymbol;
        public LLVMOpInfoSymbol1 @SubtractSymbol;
        public int @Value;
        public int @VariantKind;
    }

    public partial struct LLVMOpaqueTargetData
    {
    }

    public partial struct LLVMOpaqueTargetLibraryInfotData
    {
    }

    public partial struct LLVMOpaqueTargetMachine
    {
    }

    public partial struct LLVMTarget
    {
    }

    public partial struct LLVMOpaqueGenericValue
    {
    }

    public partial struct LLVMOpaqueExecutionEngine
    {
    }

    public partial struct LLVMOpaqueMCJITMemoryManager
    {
    }

    public partial struct LLVMMCJITCompilerOptions
    {
        public uint @OptLevel;
        public LLVMCodeModel @CodeModel;
        public int @NoFramePointerElim;
        public int @EnableFastISel;
        public IntPtr @MCJMM;
    }

    public partial struct LLVMOpaqueLTOModule
    {
    }

    public partial struct LLVMOpaqueLTOCodeGenerator
    {
    }

    public partial struct LLVMOpaqueObjectFile
    {
    }

    public partial struct LLVMOpaqueSectionIterator
    {
    }

    public partial struct LLVMOpaqueSymbolIterator
    {
    }

    public partial struct LLVMOpaqueRelocationIterator
    {
    }

    public partial struct LLVMOpaquePassManagerBuilder
    {
    }

    public partial struct LLVMBool
    {
        public LLVMBool(int value)
        {
            this.Value = value;
        }

        public int Value;
    }

    public partial struct LLVMMemoryBufferRef
    {
        public LLVMMemoryBufferRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMContextRef
    {
        public LLVMContextRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMModuleRef
    {
        public LLVMModuleRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMTypeRef
    {
        public LLVMTypeRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMValueRef
    {
        public LLVMValueRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMBasicBlockRef
    {
        public LLVMBasicBlockRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMBuilderRef
    {
        public LLVMBuilderRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMModuleProviderRef
    {
        public LLVMModuleProviderRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMPassManagerRef
    {
        public LLVMPassManagerRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMPassRegistryRef
    {
        public LLVMPassRegistryRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMUseRef
    {
        public LLVMUseRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMDiagnosticInfoRef
    {
        public LLVMDiagnosticInfoRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void LLVMFatalErrorHandler([MarshalAs(UnmanagedType.LPStr)] string @Reason);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void LLVMDiagnosticHandler(out LLVMOpaqueDiagnosticInfo @param0, IntPtr @param1);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void LLVMYieldCallback(out LLVMOpaqueContext @param0, IntPtr @param1);

    public partial struct LLVMDisasmContextRef
    {
        public LLVMDisasmContextRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int LLVMOpInfoCallback(IntPtr @DisInfo, int @PC, int @Offset, int @Size, int @TagType, IntPtr @TagBuf);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate string LLVMSymbolLookupCallback(IntPtr @DisInfo, int @ReferenceValue, out int @ReferenceType, int @ReferencePC, out IntPtr @ReferenceName);

    public partial struct LLVMTargetDataRef
    {
        public LLVMTargetDataRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMTargetLibraryInfoRef
    {
        public LLVMTargetLibraryInfoRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMTargetMachineRef
    {
        public LLVMTargetMachineRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMTargetRef
    {
        public LLVMTargetRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMGenericValueRef
    {
        public LLVMGenericValueRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMExecutionEngineRef
    {
        public LLVMExecutionEngineRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMMCJITMemoryManagerRef
    {
        public LLVMMCJITMemoryManagerRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr LLVMMemoryManagerAllocateCodeSectionCallback(IntPtr @Opaque, int @Size, uint @Alignment, uint @SectionID, [MarshalAs(UnmanagedType.LPStr)] string @SectionName);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr LLVMMemoryManagerAllocateDataSectionCallback(IntPtr @Opaque, int @Size, uint @Alignment, uint @SectionID, [MarshalAs(UnmanagedType.LPStr)] string @SectionName, int @IsReadOnly);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int LLVMMemoryManagerFinalizeMemoryCallback(IntPtr @Opaque, out IntPtr @ErrMsg);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void LLVMMemoryManagerDestroyCallback(IntPtr @Opaque);

    public partial struct llvm_lto_t
    {
        public llvm_lto_t(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct lto_bool_t
    {
        public lto_bool_t(bool value)
        {
            this.Value = value;
        }

        public bool Value;
    }

    public partial struct lto_module_t
    {
        public lto_module_t(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct lto_code_gen_t
    {
        public lto_code_gen_t(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void lto_diagnostic_handler_t(lto_codegen_diagnostic_severity_t @severity, [MarshalAs(UnmanagedType.LPStr)] string @diag, IntPtr @ctxt);

    public partial struct LLVMObjectFileRef
    {
        public LLVMObjectFileRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMSectionIteratorRef
    {
        public LLVMSectionIteratorRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMSymbolIteratorRef
    {
        public LLVMSymbolIteratorRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMRelocationIteratorRef
    {
        public LLVMRelocationIteratorRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public partial struct LLVMPassManagerBuilderRef
    {
        public LLVMPassManagerBuilderRef(IntPtr pointer)
        {
            this.Pointer = pointer;
        }

        public IntPtr Pointer;
    }

    public enum LLVMAttribute : int
    {
        @LLVMZExtAttribute = 1,
        @LLVMSExtAttribute = 2,
        @LLVMNoReturnAttribute = 4,
        @LLVMInRegAttribute = 8,
        @LLVMStructRetAttribute = 16,
        @LLVMNoUnwindAttribute = 32,
        @LLVMNoAliasAttribute = 64,
        @LLVMByValAttribute = 128,
        @LLVMNestAttribute = 256,
        @LLVMReadNoneAttribute = 512,
        @LLVMReadOnlyAttribute = 1024,
        @LLVMNoInlineAttribute = 2048,
        @LLVMAlwaysInlineAttribute = 4096,
        @LLVMOptimizeForSizeAttribute = 8192,
        @LLVMStackProtectAttribute = 16384,
        @LLVMStackProtectReqAttribute = 32768,
        @LLVMAlignment = 2031616,
        @LLVMNoCaptureAttribute = 2097152,
        @LLVMNoRedZoneAttribute = 4194304,
        @LLVMNoImplicitFloatAttribute = 8388608,
        @LLVMNakedAttribute = 16777216,
        @LLVMInlineHintAttribute = 33554432,
        @LLVMStackAlignment = 469762048,
        @LLVMReturnsTwice = 536870912,
        @LLVMUWTable = 1073741824,
        @LLVMNonLazyBind = -2147483648,
    }

    public enum LLVMOpcode : uint
    {
        @LLVMRet = 1,
        @LLVMBr = 2,
        @LLVMSwitch = 3,
        @LLVMIndirectBr = 4,
        @LLVMInvoke = 5,
        @LLVMUnreachable = 7,
        @LLVMAdd = 8,
        @LLVMFAdd = 9,
        @LLVMSub = 10,
        @LLVMFSub = 11,
        @LLVMMul = 12,
        @LLVMFMul = 13,
        @LLVMUDiv = 14,
        @LLVMSDiv = 15,
        @LLVMFDiv = 16,
        @LLVMURem = 17,
        @LLVMSRem = 18,
        @LLVMFRem = 19,
        @LLVMShl = 20,
        @LLVMLShr = 21,
        @LLVMAShr = 22,
        @LLVMAnd = 23,
        @LLVMOr = 24,
        @LLVMXor = 25,
        @LLVMAlloca = 26,
        @LLVMLoad = 27,
        @LLVMStore = 28,
        @LLVMGetElementPtr = 29,
        @LLVMTrunc = 30,
        @LLVMZExt = 31,
        @LLVMSExt = 32,
        @LLVMFPToUI = 33,
        @LLVMFPToSI = 34,
        @LLVMUIToFP = 35,
        @LLVMSIToFP = 36,
        @LLVMFPTrunc = 37,
        @LLVMFPExt = 38,
        @LLVMPtrToInt = 39,
        @LLVMIntToPtr = 40,
        @LLVMBitCast = 41,
        @LLVMAddrSpaceCast = 60,
        @LLVMICmp = 42,
        @LLVMFCmp = 43,
        @LLVMPHI = 44,
        @LLVMCall = 45,
        @LLVMSelect = 46,
        @LLVMUserOp1 = 47,
        @LLVMUserOp2 = 48,
        @LLVMVAArg = 49,
        @LLVMExtractElement = 50,
        @LLVMInsertElement = 51,
        @LLVMShuffleVector = 52,
        @LLVMExtractValue = 53,
        @LLVMInsertValue = 54,
        @LLVMFence = 55,
        @LLVMAtomicCmpXchg = 56,
        @LLVMAtomicRMW = 57,
        @LLVMResume = 58,
        @LLVMLandingPad = 59,
    }

    public enum LLVMTypeKind : uint
    {
        @LLVMVoidTypeKind = 0,
        @LLVMHalfTypeKind = 1,
        @LLVMFloatTypeKind = 2,
        @LLVMDoubleTypeKind = 3,
        @LLVMX86_FP80TypeKind = 4,
        @LLVMFP128TypeKind = 5,
        @LLVMPPC_FP128TypeKind = 6,
        @LLVMLabelTypeKind = 7,
        @LLVMIntegerTypeKind = 8,
        @LLVMFunctionTypeKind = 9,
        @LLVMStructTypeKind = 10,
        @LLVMArrayTypeKind = 11,
        @LLVMPointerTypeKind = 12,
        @LLVMVectorTypeKind = 13,
        @LLVMMetadataTypeKind = 14,
        @LLVMX86_MMXTypeKind = 15,
    }

    public enum LLVMLinkage : uint
    {
        @LLVMExternalLinkage = 0,
        @LLVMAvailableExternallyLinkage = 1,
        @LLVMLinkOnceAnyLinkage = 2,
        @LLVMLinkOnceODRLinkage = 3,
        @LLVMLinkOnceODRAutoHideLinkage = 4,
        @LLVMWeakAnyLinkage = 5,
        @LLVMWeakODRLinkage = 6,
        @LLVMAppendingLinkage = 7,
        @LLVMInternalLinkage = 8,
        @LLVMPrivateLinkage = 9,
        @LLVMDLLImportLinkage = 10,
        @LLVMDLLExportLinkage = 11,
        @LLVMExternalWeakLinkage = 12,
        @LLVMGhostLinkage = 13,
        @LLVMCommonLinkage = 14,
        @LLVMLinkerPrivateLinkage = 15,
        @LLVMLinkerPrivateWeakLinkage = 16,
    }

    public enum LLVMVisibility : uint
    {
        @LLVMDefaultVisibility = 0,
        @LLVMHiddenVisibility = 1,
        @LLVMProtectedVisibility = 2,
    }

    public enum LLVMDLLStorageClass : uint
    {
        @LLVMDefaultStorageClass = 0,
        @LLVMDLLImportStorageClass = 1,
        @LLVMDLLExportStorageClass = 2,
    }

    public enum LLVMCallConv : uint
    {
        @LLVMCCallConv = 0,
        @LLVMFastCallConv = 8,
        @LLVMColdCallConv = 9,
        @LLVMWebKitJSCallConv = 12,
        @LLVMAnyRegCallConv = 13,
        @LLVMX86StdcallCallConv = 64,
        @LLVMX86FastcallCallConv = 65,
    }

    public enum LLVMIntPredicate : uint
    {
        @LLVMIntEQ = 32,
        @LLVMIntNE = 33,
        @LLVMIntUGT = 34,
        @LLVMIntUGE = 35,
        @LLVMIntULT = 36,
        @LLVMIntULE = 37,
        @LLVMIntSGT = 38,
        @LLVMIntSGE = 39,
        @LLVMIntSLT = 40,
        @LLVMIntSLE = 41,
    }

    public enum LLVMRealPredicate : uint
    {
        @LLVMRealPredicateFalse = 0,
        @LLVMRealOEQ = 1,
        @LLVMRealOGT = 2,
        @LLVMRealOGE = 3,
        @LLVMRealOLT = 4,
        @LLVMRealOLE = 5,
        @LLVMRealONE = 6,
        @LLVMRealORD = 7,
        @LLVMRealUNO = 8,
        @LLVMRealUEQ = 9,
        @LLVMRealUGT = 10,
        @LLVMRealUGE = 11,
        @LLVMRealULT = 12,
        @LLVMRealULE = 13,
        @LLVMRealUNE = 14,
        @LLVMRealPredicateTrue = 15,
    }

    public enum LLVMLandingPadClauseTy : uint
    {
        @LLVMLandingPadCatch = 0,
        @LLVMLandingPadFilter = 1,
    }

    public enum LLVMThreadLocalMode : uint
    {
        @LLVMNotThreadLocal = 0,
        @LLVMGeneralDynamicTLSModel = 1,
        @LLVMLocalDynamicTLSModel = 2,
        @LLVMInitialExecTLSModel = 3,
        @LLVMLocalExecTLSModel = 4,
    }

    public enum LLVMAtomicOrdering : uint
    {
        @LLVMAtomicOrderingNotAtomic = 0,
        @LLVMAtomicOrderingUnordered = 1,
        @LLVMAtomicOrderingMonotonic = 2,
        @LLVMAtomicOrderingAcquire = 4,
        @LLVMAtomicOrderingRelease = 5,
        @LLVMAtomicOrderingAcquireRelease = 6,
        @LLVMAtomicOrderingSequentiallyConsistent = 7,
    }

    public enum LLVMAtomicRMWBinOp : uint
    {
        @LLVMAtomicRMWBinOpXchg = 0,
        @LLVMAtomicRMWBinOpAdd = 1,
        @LLVMAtomicRMWBinOpSub = 2,
        @LLVMAtomicRMWBinOpAnd = 3,
        @LLVMAtomicRMWBinOpNand = 4,
        @LLVMAtomicRMWBinOpOr = 5,
        @LLVMAtomicRMWBinOpXor = 6,
        @LLVMAtomicRMWBinOpMax = 7,
        @LLVMAtomicRMWBinOpMin = 8,
        @LLVMAtomicRMWBinOpUMax = 9,
        @LLVMAtomicRMWBinOpUMin = 10,
    }

    public enum LLVMDiagnosticSeverity : uint
    {
        @LLVMDSError = 0,
        @LLVMDSWarning = 1,
        @LLVMDSRemark = 2,
        @LLVMDSNote = 3,
    }

    public enum LLVMVerifierFailureAction : uint
    {
        @LLVMAbortProcessAction = 0,
        @LLVMPrintMessageAction = 1,
        @LLVMReturnStatusAction = 2,
    }

    public enum LLVMByteOrdering : uint
    {
        @LLVMBigEndian = 0,
        @LLVMLittleEndian = 1,
    }

    public enum LLVMCodeGenOptLevel : uint
    {
        @LLVMCodeGenLevelNone = 0,
        @LLVMCodeGenLevelLess = 1,
        @LLVMCodeGenLevelDefault = 2,
        @LLVMCodeGenLevelAggressive = 3,
    }

    public enum LLVMRelocMode : uint
    {
        @LLVMRelocDefault = 0,
        @LLVMRelocStatic = 1,
        @LLVMRelocPIC = 2,
        @LLVMRelocDynamicNoPic = 3,
    }

    public enum LLVMCodeModel : uint
    {
        @LLVMCodeModelDefault = 0,
        @LLVMCodeModelJITDefault = 1,
        @LLVMCodeModelSmall = 2,
        @LLVMCodeModelKernel = 3,
        @LLVMCodeModelMedium = 4,
        @LLVMCodeModelLarge = 5,
    }

    public enum LLVMCodeGenFileType : uint
    {
        @LLVMAssemblyFile = 0,
        @LLVMObjectFile = 1,
    }

    public enum llvm_lto_status : uint
    {
        @LLVM_LTO_UNKNOWN = 0,
        @LLVM_LTO_OPT_SUCCESS = 1,
        @LLVM_LTO_READ_SUCCESS = 2,
        @LLVM_LTO_READ_FAILURE = 3,
        @LLVM_LTO_WRITE_FAILURE = 4,
        @LLVM_LTO_NO_TARGET = 5,
        @LLVM_LTO_NO_WORK = 6,
        @LLVM_LTO_MODULE_MERGE_FAILURE = 7,
        @LLVM_LTO_ASM_FAILURE = 8,
        @LLVM_LTO_NULL_OBJECT = 9,
    }

    public enum lto_symbol_attributes : uint
    {
        @LTO_SYMBOL_ALIGNMENT_MASK = 31,
        @LTO_SYMBOL_PERMISSIONS_MASK = 224,
        @LTO_SYMBOL_PERMISSIONS_CODE = 160,
        @LTO_SYMBOL_PERMISSIONS_DATA = 192,
        @LTO_SYMBOL_PERMISSIONS_RODATA = 128,
        @LTO_SYMBOL_DEFINITION_MASK = 1792,
        @LTO_SYMBOL_DEFINITION_REGULAR = 256,
        @LTO_SYMBOL_DEFINITION_TENTATIVE = 512,
        @LTO_SYMBOL_DEFINITION_WEAK = 768,
        @LTO_SYMBOL_DEFINITION_UNDEFINED = 1024,
        @LTO_SYMBOL_DEFINITION_WEAKUNDEF = 1280,
        @LTO_SYMBOL_SCOPE_MASK = 14336,
        @LTO_SYMBOL_SCOPE_INTERNAL = 2048,
        @LTO_SYMBOL_SCOPE_HIDDEN = 4096,
        @LTO_SYMBOL_SCOPE_PROTECTED = 8192,
        @LTO_SYMBOL_SCOPE_DEFAULT = 6144,
        @LTO_SYMBOL_SCOPE_DEFAULT_CAN_BE_HIDDEN = 10240,
    }

    public enum lto_debug_model : uint
    {
        @LTO_DEBUG_MODEL_NONE = 0,
        @LTO_DEBUG_MODEL_DWARF = 1,
    }

    public enum lto_codegen_model : uint
    {
        @LTO_CODEGEN_PIC_MODEL_STATIC = 0,
        @LTO_CODEGEN_PIC_MODEL_DYNAMIC = 1,
        @LTO_CODEGEN_PIC_MODEL_DYNAMIC_NO_PIC = 2,
        @LTO_CODEGEN_PIC_MODEL_DEFAULT = 3,
    }

    public enum lto_codegen_diagnostic_severity_t : uint
    {
        @LTO_DS_ERROR = 0,
        @LTO_DS_WARNING = 1,
        @LTO_DS_REMARK = 3,
        @LTO_DS_NOTE = 2,
    }

    public static partial class LLVM
    {
        private const string libraryPath = "llvm.dll";

        [DllImport(libraryPath, EntryPoint = "LLVMLoadLibraryPermanently", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool LoadLibraryPermanently([MarshalAs(UnmanagedType.LPStr)] string @Filename);

        [DllImport(libraryPath, EntryPoint = "LLVMParseCommandLineOptions", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ParseCommandLineOptions(int @argc, string[] @argv, [MarshalAs(UnmanagedType.LPStr)] string @Overview);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeCore", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeCore(LLVMPassRegistryRef @R);

        [DllImport(libraryPath, EntryPoint = "LLVMShutdown", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Shutdown();

        [DllImport(libraryPath, EntryPoint = "LLVMCreateMessage", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CreateMessage([MarshalAs(UnmanagedType.LPStr)] string @Message);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeMessage", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeMessage(IntPtr @Message);

        [DllImport(libraryPath, EntryPoint = "LLVMInstallFatalErrorHandler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InstallFatalErrorHandler(LLVMFatalErrorHandler @Handler);

        [DllImport(libraryPath, EntryPoint = "LLVMResetFatalErrorHandler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ResetFatalErrorHandler();

        [DllImport(libraryPath, EntryPoint = "LLVMEnablePrettyStackTrace", CallingConvention = CallingConvention.Cdecl)]
        public static extern void EnablePrettyStackTrace();

        [DllImport(libraryPath, EntryPoint = "LLVMContextCreate", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMContextRef ContextCreate();

        [DllImport(libraryPath, EntryPoint = "LLVMGetGlobalContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMContextRef GetGlobalContext();

        [DllImport(libraryPath, EntryPoint = "LLVMContextSetDiagnosticHandler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ContextSetDiagnosticHandler(LLVMContextRef @C, LLVMDiagnosticHandler @Handler, IntPtr @DiagnosticContext);

        [DllImport(libraryPath, EntryPoint = "LLVMContextSetYieldCallback", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ContextSetYieldCallback(LLVMContextRef @C, LLVMYieldCallback @Callback, IntPtr @OpaqueHandle);

        [DllImport(libraryPath, EntryPoint = "LLVMContextDispose", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ContextDispose(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMGetDiagInfoDescription", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetDiagInfoDescription(LLVMDiagnosticInfoRef @DI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetDiagInfoSeverity", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMDiagnosticSeverity GetDiagInfoSeverity(LLVMDiagnosticInfoRef @DI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetMDKindIDInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetMDKindIDInContext(LLVMContextRef @C, [MarshalAs(UnmanagedType.LPStr)] string @Name, uint @SLen);

        [DllImport(libraryPath, EntryPoint = "LLVMGetMDKindID", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetMDKindID([MarshalAs(UnmanagedType.LPStr)] string @Name, uint @SLen);

        [DllImport(libraryPath, EntryPoint = "LLVMModuleCreateWithName", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMModuleRef ModuleCreateWithName([MarshalAs(UnmanagedType.LPStr)] string @ModuleID);

        [DllImport(libraryPath, EntryPoint = "LLVMModuleCreateWithNameInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMModuleRef ModuleCreateWithNameInContext([MarshalAs(UnmanagedType.LPStr)] string @ModuleID, LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMCloneModule", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMModuleRef CloneModule(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeModule", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeModule(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMGetDataLayout", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetDataLayout(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMSetDataLayout", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetDataLayout(LLVMModuleRef @M, [MarshalAs(UnmanagedType.LPStr)] string @Triple);

        [DllImport(libraryPath, EntryPoint = "LLVMGetTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetTarget(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMSetTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTarget(LLVMModuleRef @M, [MarshalAs(UnmanagedType.LPStr)] string @Triple);

        [DllImport(libraryPath, EntryPoint = "LLVMDumpModule", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DumpModule(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMPrintModuleToFile", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool PrintModuleToFile(LLVMModuleRef @M, [MarshalAs(UnmanagedType.LPStr)] string @Filename, out IntPtr @ErrorMessage);

        [DllImport(libraryPath, EntryPoint = "LLVMPrintModuleToString", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr PrintModuleToString(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMSetModuleInlineAsm", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetModuleInlineAsm(LLVMModuleRef @M, [MarshalAs(UnmanagedType.LPStr)] string @Asm);

        [DllImport(libraryPath, EntryPoint = "LLVMGetModuleContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMContextRef GetModuleContext(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMGetTypeByName", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef GetTypeByName(LLVMModuleRef @M, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMGetNamedMetadataNumOperands", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetNamedMetadataNumOperands(LLVMModuleRef @M, [MarshalAs(UnmanagedType.LPStr)] string @name);

        [DllImport(libraryPath, EntryPoint = "LLVMGetNamedMetadataOperands", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetNamedMetadataOperands(LLVMModuleRef @M, [MarshalAs(UnmanagedType.LPStr)] string @name, out LLVMValueRef @Dest);

        [DllImport(libraryPath, EntryPoint = "LLVMAddNamedMetadataOperand", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddNamedMetadataOperand(LLVMModuleRef @M, [MarshalAs(UnmanagedType.LPStr)] string @name, LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMAddFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef AddFunction(LLVMModuleRef @M, [MarshalAs(UnmanagedType.LPStr)] string @Name, LLVMTypeRef @FunctionTy);

        [DllImport(libraryPath, EntryPoint = "LLVMGetNamedFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetNamedFunction(LLVMModuleRef @M, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMGetFirstFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetFirstFunction(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMGetLastFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetLastFunction(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMGetNextFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetNextFunction(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMGetPreviousFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetPreviousFunction(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMGetTypeKind", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeKind GetTypeKind(LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMTypeIsSized", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool TypeIsSized(LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMGetTypeContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMContextRef GetTypeContext(LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMDumpType", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DumpType(LLVMTypeRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMPrintTypeToString", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr PrintTypeToString(LLVMTypeRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMInt1TypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef Int1TypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMInt8TypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef Int8TypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMInt16TypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef Int16TypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMInt32TypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef Int32TypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMInt64TypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef Int64TypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMIntTypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef IntTypeInContext(LLVMContextRef @C, uint @NumBits);

        [DllImport(libraryPath, EntryPoint = "LLVMInt1Type", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef Int1Type();

        [DllImport(libraryPath, EntryPoint = "LLVMInt8Type", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef Int8Type();

        [DllImport(libraryPath, EntryPoint = "LLVMInt16Type", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef Int16Type();

        [DllImport(libraryPath, EntryPoint = "LLVMInt32Type", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef Int32Type();

        [DllImport(libraryPath, EntryPoint = "LLVMInt64Type", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef Int64Type();

        [DllImport(libraryPath, EntryPoint = "LLVMIntType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef IntType(uint @NumBits);

        [DllImport(libraryPath, EntryPoint = "LLVMGetIntTypeWidth", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetIntTypeWidth(LLVMTypeRef @IntegerTy);

        [DllImport(libraryPath, EntryPoint = "LLVMHalfTypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef HalfTypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMFloatTypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef FloatTypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMDoubleTypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef DoubleTypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMX86FP80TypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef X86FP80TypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMFP128TypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef FP128TypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMPPCFP128TypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef PPCFP128TypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMHalfType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef HalfType();

        [DllImport(libraryPath, EntryPoint = "LLVMFloatType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef FloatType();

        [DllImport(libraryPath, EntryPoint = "LLVMDoubleType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef DoubleType();

        [DllImport(libraryPath, EntryPoint = "LLVMX86FP80Type", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef X86FP80Type();

        [DllImport(libraryPath, EntryPoint = "LLVMFP128Type", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef FP128Type();

        [DllImport(libraryPath, EntryPoint = "LLVMPPCFP128Type", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef PPCFP128Type();

        [DllImport(libraryPath, EntryPoint = "LLVMFunctionType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef FunctionType(LLVMTypeRef @ReturnType, out LLVMTypeRef @ParamTypes, uint @ParamCount, LLVMBool @IsVarArg);

        [DllImport(libraryPath, EntryPoint = "LLVMIsFunctionVarArg", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsFunctionVarArg(LLVMTypeRef @FunctionTy);

        [DllImport(libraryPath, EntryPoint = "LLVMGetReturnType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef GetReturnType(LLVMTypeRef @FunctionTy);

        [DllImport(libraryPath, EntryPoint = "LLVMCountParamTypes", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint CountParamTypes(LLVMTypeRef @FunctionTy);

        [DllImport(libraryPath, EntryPoint = "LLVMGetParamTypes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetParamTypes(LLVMTypeRef @FunctionTy, out LLVMTypeRef @Dest);

        [DllImport(libraryPath, EntryPoint = "LLVMStructTypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef StructTypeInContext(LLVMContextRef @C, out LLVMTypeRef @ElementTypes, uint @ElementCount, LLVMBool @Packed);

        [DllImport(libraryPath, EntryPoint = "LLVMStructType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef StructType(out LLVMTypeRef @ElementTypes, uint @ElementCount, LLVMBool @Packed);

        [DllImport(libraryPath, EntryPoint = "LLVMStructCreateNamed", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef StructCreateNamed(LLVMContextRef @C, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMGetStructName", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetStructName(LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMStructSetBody", CallingConvention = CallingConvention.Cdecl)]
        public static extern void StructSetBody(LLVMTypeRef @StructTy, out LLVMTypeRef @ElementTypes, uint @ElementCount, LLVMBool @Packed);

        [DllImport(libraryPath, EntryPoint = "LLVMCountStructElementTypes", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint CountStructElementTypes(LLVMTypeRef @StructTy);

        [DllImport(libraryPath, EntryPoint = "LLVMGetStructElementTypes", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetStructElementTypes(LLVMTypeRef @StructTy, out LLVMTypeRef @Dest);

        [DllImport(libraryPath, EntryPoint = "LLVMIsPackedStruct", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsPackedStruct(LLVMTypeRef @StructTy);

        [DllImport(libraryPath, EntryPoint = "LLVMIsOpaqueStruct", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsOpaqueStruct(LLVMTypeRef @StructTy);

        [DllImport(libraryPath, EntryPoint = "LLVMGetElementType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef GetElementType(LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMArrayType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef ArrayType(LLVMTypeRef @ElementType, uint @ElementCount);

        [DllImport(libraryPath, EntryPoint = "LLVMGetArrayLength", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetArrayLength(LLVMTypeRef @ArrayTy);

        [DllImport(libraryPath, EntryPoint = "LLVMPointerType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef PointerType(LLVMTypeRef @ElementType, uint @AddressSpace);

        [DllImport(libraryPath, EntryPoint = "LLVMGetPointerAddressSpace", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetPointerAddressSpace(LLVMTypeRef @PointerTy);

        [DllImport(libraryPath, EntryPoint = "LLVMVectorType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef VectorType(LLVMTypeRef @ElementType, uint @ElementCount);

        [DllImport(libraryPath, EntryPoint = "LLVMGetVectorSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetVectorSize(LLVMTypeRef @VectorTy);

        [DllImport(libraryPath, EntryPoint = "LLVMVoidTypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef VoidTypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMLabelTypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef LabelTypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMX86MMXTypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef X86MMXTypeInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMVoidType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef VoidType();

        [DllImport(libraryPath, EntryPoint = "LLVMLabelType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef LabelType();

        [DllImport(libraryPath, EntryPoint = "LLVMX86MMXType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef X86MMXType();

        [DllImport(libraryPath, EntryPoint = "LLVMTypeOf", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef TypeOf(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMGetValueName", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetValueName(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMSetValueName", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetValueName(LLVMValueRef @Val, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMDumpValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DumpValue(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMPrintValueToString", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr PrintValueToString(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMReplaceAllUsesWith", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ReplaceAllUsesWith(LLVMValueRef @OldVal, LLVMValueRef @NewVal);

        [DllImport(libraryPath, EntryPoint = "LLVMIsConstant", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsConstant(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsUndef", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsUndef(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAArgument", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAArgument(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsABasicBlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsABasicBlock(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAInlineAsm", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAInlineAsm(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAUser", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAUser(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAConstant", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAConstant(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsABlockAddress", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsABlockAddress(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAConstantAggregateZero", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAConstantAggregateZero(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAConstantArray", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAConstantArray(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAConstantDataSequential", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAConstantDataSequential(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAConstantDataArray", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAConstantDataArray(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAConstantDataVector", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAConstantDataVector(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAConstantExpr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAConstantExpr(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAConstantFP", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAConstantFP(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAConstantInt", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAConstantInt(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAConstantPointerNull", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAConstantPointerNull(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAConstantStruct", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAConstantStruct(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAConstantVector", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAConstantVector(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAGlobalValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAGlobalValue(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAGlobalAlias", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAGlobalAlias(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAGlobalObject", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAGlobalObject(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAFunction(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAGlobalVariable", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAGlobalVariable(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAUndefValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAUndefValue(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAInstruction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAInstruction(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsABinaryOperator", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsABinaryOperator(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsACallInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsACallInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAIntrinsicInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAIntrinsicInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsADbgInfoIntrinsic", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsADbgInfoIntrinsic(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsADbgDeclareInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsADbgDeclareInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAMemIntrinsic", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAMemIntrinsic(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAMemCpyInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAMemCpyInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAMemMoveInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAMemMoveInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAMemSetInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAMemSetInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsACmpInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsACmpInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAFCmpInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAFCmpInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAICmpInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAICmpInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAExtractElementInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAExtractElementInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAGetElementPtrInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAGetElementPtrInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAInsertElementInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAInsertElementInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAInsertValueInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAInsertValueInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsALandingPadInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsALandingPadInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAPHINode", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAPHINode(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsASelectInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsASelectInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAShuffleVectorInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAShuffleVectorInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAStoreInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAStoreInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsATerminatorInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsATerminatorInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsABranchInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsABranchInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAIndirectBrInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAIndirectBrInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAInvokeInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAInvokeInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAReturnInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAReturnInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsASwitchInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsASwitchInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAUnreachableInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAUnreachableInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAResumeInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAResumeInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAUnaryInstruction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAUnaryInstruction(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAAllocaInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAAllocaInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsACastInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsACastInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAAddrSpaceCastInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAAddrSpaceCastInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsABitCastInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsABitCastInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAFPExtInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAFPExtInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAFPToSIInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAFPToSIInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAFPToUIInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAFPToUIInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAFPTruncInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAFPTruncInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAIntToPtrInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAIntToPtrInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAPtrToIntInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAPtrToIntInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsASExtInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsASExtInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsASIToFPInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsASIToFPInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsATruncInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsATruncInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAUIToFPInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAUIToFPInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAZExtInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAZExtInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAExtractValueInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAExtractValueInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsALoadInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsALoadInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAVAArgInst", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAVAArgInst(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAMDNode", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAMDNode(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMIsAMDString", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef IsAMDString(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMGetFirstUse", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMUseRef GetFirstUse(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMGetNextUse", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMUseRef GetNextUse(LLVMUseRef @U);

        [DllImport(libraryPath, EntryPoint = "LLVMGetUser", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetUser(LLVMUseRef @U);

        [DllImport(libraryPath, EntryPoint = "LLVMGetUsedValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetUsedValue(LLVMUseRef @U);

        [DllImport(libraryPath, EntryPoint = "LLVMGetOperand", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetOperand(LLVMValueRef @Val, uint @Index);

        [DllImport(libraryPath, EntryPoint = "LLVMGetOperandUse", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMUseRef GetOperandUse(LLVMValueRef @Val, uint @Index);

        [DllImport(libraryPath, EntryPoint = "LLVMSetOperand", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetOperand(LLVMValueRef @User, uint @Index, LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMGetNumOperands", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetNumOperands(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMConstNull", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstNull(LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMConstAllOnes", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstAllOnes(LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMGetUndef", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetUndef(LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMIsNull", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsNull(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMConstPointerNull", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstPointerNull(LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMConstInt", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstInt(LLVMTypeRef @IntTy, ulong @N, LLVMBool @SignExtend);

        [DllImport(libraryPath, EntryPoint = "LLVMConstIntOfArbitraryPrecision", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstIntOfArbitraryPrecision(LLVMTypeRef @IntTy, uint @NumWords, int[] @Words);

        [DllImport(libraryPath, EntryPoint = "LLVMConstIntOfString", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstIntOfString(LLVMTypeRef @IntTy, [MarshalAs(UnmanagedType.LPStr)] string @Text, char @Radix);

        [DllImport(libraryPath, EntryPoint = "LLVMConstIntOfStringAndSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstIntOfStringAndSize(LLVMTypeRef @IntTy, [MarshalAs(UnmanagedType.LPStr)] string @Text, uint @SLen, char @Radix);

        [DllImport(libraryPath, EntryPoint = "LLVMConstReal", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstReal(LLVMTypeRef @RealTy, double @N);

        [DllImport(libraryPath, EntryPoint = "LLVMConstRealOfString", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstRealOfString(LLVMTypeRef @RealTy, [MarshalAs(UnmanagedType.LPStr)] string @Text);

        [DllImport(libraryPath, EntryPoint = "LLVMConstRealOfStringAndSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstRealOfStringAndSize(LLVMTypeRef @RealTy, [MarshalAs(UnmanagedType.LPStr)] string @Text, uint @SLen);

        [DllImport(libraryPath, EntryPoint = "LLVMConstIntGetZExtValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong ConstIntGetZExtValue(LLVMValueRef @ConstantVal);

        [DllImport(libraryPath, EntryPoint = "LLVMConstIntGetSExtValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern long ConstIntGetSExtValue(LLVMValueRef @ConstantVal);

        [DllImport(libraryPath, EntryPoint = "LLVMConstRealGetDouble", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ConstRealGetDouble(LLVMValueRef @ConstantVal, out LLVMBool @losesInfo);

        [DllImport(libraryPath, EntryPoint = "LLVMConstStringInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstStringInContext(LLVMContextRef @C, [MarshalAs(UnmanagedType.LPStr)] string @Str, uint @Length, LLVMBool @DontNullTerminate);

        [DllImport(libraryPath, EntryPoint = "LLVMConstString", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstString([MarshalAs(UnmanagedType.LPStr)] string @Str, uint @Length, LLVMBool @DontNullTerminate);

        [DllImport(libraryPath, EntryPoint = "LLVMIsConstantString", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsConstantString(LLVMValueRef @c);

        [DllImport(libraryPath, EntryPoint = "LLVMGetAsString", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetAsString(LLVMValueRef @c, out int @out);

        [DllImport(libraryPath, EntryPoint = "LLVMConstStructInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstStructInContext(LLVMContextRef @C, out LLVMValueRef @ConstantVals, uint @Count, LLVMBool @Packed);

        [DllImport(libraryPath, EntryPoint = "LLVMConstStruct", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstStruct(out LLVMValueRef @ConstantVals, uint @Count, LLVMBool @Packed);

        [DllImport(libraryPath, EntryPoint = "LLVMConstArray", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstArray(LLVMTypeRef @ElementTy, out LLVMValueRef @ConstantVals, uint @Length);

        [DllImport(libraryPath, EntryPoint = "LLVMConstNamedStruct", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstNamedStruct(LLVMTypeRef @StructTy, out LLVMValueRef @ConstantVals, uint @Count);

        [DllImport(libraryPath, EntryPoint = "LLVMGetElementAsConstant", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetElementAsConstant(LLVMValueRef @c, uint @idx);

        [DllImport(libraryPath, EntryPoint = "LLVMConstVector", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstVector(out LLVMValueRef @ScalarConstantVals, uint @Size);

        [DllImport(libraryPath, EntryPoint = "LLVMGetConstOpcode", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMOpcode GetConstOpcode(LLVMValueRef @ConstantVal);

        [DllImport(libraryPath, EntryPoint = "LLVMAlignOf", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef AlignOf(LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMSizeOf", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef SizeOf(LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMConstNeg", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstNeg(LLVMValueRef @ConstantVal);

        [DllImport(libraryPath, EntryPoint = "LLVMConstNSWNeg", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstNSWNeg(LLVMValueRef @ConstantVal);

        [DllImport(libraryPath, EntryPoint = "LLVMConstNUWNeg", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstNUWNeg(LLVMValueRef @ConstantVal);

        [DllImport(libraryPath, EntryPoint = "LLVMConstFNeg", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstFNeg(LLVMValueRef @ConstantVal);

        [DllImport(libraryPath, EntryPoint = "LLVMConstNot", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstNot(LLVMValueRef @ConstantVal);

        [DllImport(libraryPath, EntryPoint = "LLVMConstAdd", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstAdd(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstNSWAdd", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstNSWAdd(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstNUWAdd", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstNUWAdd(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstFAdd", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstFAdd(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstSub", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstSub(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstNSWSub", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstNSWSub(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstNUWSub", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstNUWSub(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstFSub", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstFSub(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstMul", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstMul(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstNSWMul", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstNSWMul(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstNUWMul", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstNUWMul(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstFMul", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstFMul(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstUDiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstUDiv(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstSDiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstSDiv(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstExactSDiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstExactSDiv(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstFDiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstFDiv(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstURem", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstURem(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstSRem", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstSRem(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstFRem", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstFRem(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstAnd", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstAnd(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstOr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstOr(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstXor", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstXor(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstICmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstICmp(LLVMIntPredicate @Predicate, LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstFCmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstFCmp(LLVMRealPredicate @Predicate, LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstShl", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstShl(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstLShr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstLShr(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstAShr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstAShr(LLVMValueRef @LHSConstant, LLVMValueRef @RHSConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstGEP", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstGEP(LLVMValueRef @ConstantVal, out LLVMValueRef @ConstantIndices, uint @NumIndices);

        [DllImport(libraryPath, EntryPoint = "LLVMConstInBoundsGEP", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstInBoundsGEP(LLVMValueRef @ConstantVal, out LLVMValueRef @ConstantIndices, uint @NumIndices);

        [DllImport(libraryPath, EntryPoint = "LLVMConstTrunc", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstTrunc(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstSExt", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstSExt(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstZExt", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstZExt(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstFPTrunc", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstFPTrunc(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstFPExt", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstFPExt(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstUIToFP", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstUIToFP(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstSIToFP", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstSIToFP(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstFPToUI", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstFPToUI(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstFPToSI", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstFPToSI(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstPtrToInt", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstPtrToInt(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstIntToPtr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstIntToPtr(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstBitCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstBitCast(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstAddrSpaceCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstAddrSpaceCast(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstZExtOrBitCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstZExtOrBitCast(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstSExtOrBitCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstSExtOrBitCast(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstTruncOrBitCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstTruncOrBitCast(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstPointerCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstPointerCast(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstIntCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstIntCast(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType, LLVMBool @isSigned);

        [DllImport(libraryPath, EntryPoint = "LLVMConstFPCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstFPCast(LLVMValueRef @ConstantVal, LLVMTypeRef @ToType);

        [DllImport(libraryPath, EntryPoint = "LLVMConstSelect", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstSelect(LLVMValueRef @ConstantCondition, LLVMValueRef @ConstantIfTrue, LLVMValueRef @ConstantIfFalse);

        [DllImport(libraryPath, EntryPoint = "LLVMConstExtractElement", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstExtractElement(LLVMValueRef @VectorConstant, LLVMValueRef @IndexConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstInsertElement", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstInsertElement(LLVMValueRef @VectorConstant, LLVMValueRef @ElementValueConstant, LLVMValueRef @IndexConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstShuffleVector", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstShuffleVector(LLVMValueRef @VectorAConstant, LLVMValueRef @VectorBConstant, LLVMValueRef @MaskConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMConstExtractValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstExtractValue(LLVMValueRef @AggConstant, out uint @IdxList, uint @NumIdx);

        [DllImport(libraryPath, EntryPoint = "LLVMConstInsertValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstInsertValue(LLVMValueRef @AggConstant, LLVMValueRef @ElementValueConstant, out uint @IdxList, uint @NumIdx);

        [DllImport(libraryPath, EntryPoint = "LLVMConstInlineAsm", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef ConstInlineAsm(LLVMTypeRef @Ty, [MarshalAs(UnmanagedType.LPStr)] string @AsmString, [MarshalAs(UnmanagedType.LPStr)] string @Constraints, LLVMBool @HasSideEffects, LLVMBool @IsAlignStack);

        [DllImport(libraryPath, EntryPoint = "LLVMBlockAddress", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BlockAddress(LLVMValueRef @F, LLVMBasicBlockRef @BB);

        [DllImport(libraryPath, EntryPoint = "LLVMGetGlobalParent", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMModuleRef GetGlobalParent(LLVMValueRef @Global);

        [DllImport(libraryPath, EntryPoint = "LLVMIsDeclaration", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsDeclaration(LLVMValueRef @Global);

        [DllImport(libraryPath, EntryPoint = "LLVMGetLinkage", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMLinkage GetLinkage(LLVMValueRef @Global);

        [DllImport(libraryPath, EntryPoint = "LLVMSetLinkage", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetLinkage(LLVMValueRef @Global, LLVMLinkage @Linkage);

        [DllImport(libraryPath, EntryPoint = "LLVMGetSection", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetSection(LLVMValueRef @Global);

        [DllImport(libraryPath, EntryPoint = "LLVMSetSection", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetSection(LLVMValueRef @Global, [MarshalAs(UnmanagedType.LPStr)] string @Section);

        [DllImport(libraryPath, EntryPoint = "LLVMGetVisibility", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMVisibility GetVisibility(LLVMValueRef @Global);

        [DllImport(libraryPath, EntryPoint = "LLVMSetVisibility", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetVisibility(LLVMValueRef @Global, LLVMVisibility @Viz);

        [DllImport(libraryPath, EntryPoint = "LLVMGetDLLStorageClass", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMDLLStorageClass GetDLLStorageClass(LLVMValueRef @Global);

        [DllImport(libraryPath, EntryPoint = "LLVMSetDLLStorageClass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetDLLStorageClass(LLVMValueRef @Global, LLVMDLLStorageClass @Class);

        [DllImport(libraryPath, EntryPoint = "LLVMHasUnnamedAddr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool HasUnnamedAddr(LLVMValueRef @Global);

        [DllImport(libraryPath, EntryPoint = "LLVMSetUnnamedAddr", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetUnnamedAddr(LLVMValueRef @Global, LLVMBool @HasUnnamedAddr);

        [DllImport(libraryPath, EntryPoint = "LLVMGetAlignment", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetAlignment(LLVMValueRef @V);

        [DllImport(libraryPath, EntryPoint = "LLVMSetAlignment", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetAlignment(LLVMValueRef @V, uint @Bytes);

        [DllImport(libraryPath, EntryPoint = "LLVMAddGlobal", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef AddGlobal(LLVMModuleRef @M, LLVMTypeRef @Ty, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMAddGlobalInAddressSpace", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef AddGlobalInAddressSpace(LLVMModuleRef @M, LLVMTypeRef @Ty, [MarshalAs(UnmanagedType.LPStr)] string @Name, uint @AddressSpace);

        [DllImport(libraryPath, EntryPoint = "LLVMGetNamedGlobal", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetNamedGlobal(LLVMModuleRef @M, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMGetFirstGlobal", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetFirstGlobal(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMGetLastGlobal", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetLastGlobal(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMGetNextGlobal", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetNextGlobal(LLVMValueRef @GlobalVar);

        [DllImport(libraryPath, EntryPoint = "LLVMGetPreviousGlobal", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetPreviousGlobal(LLVMValueRef @GlobalVar);

        [DllImport(libraryPath, EntryPoint = "LLVMDeleteGlobal", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DeleteGlobal(LLVMValueRef @GlobalVar);

        [DllImport(libraryPath, EntryPoint = "LLVMGetInitializer", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetInitializer(LLVMValueRef @GlobalVar);

        [DllImport(libraryPath, EntryPoint = "LLVMSetInitializer", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetInitializer(LLVMValueRef @GlobalVar, LLVMValueRef @ConstantVal);

        [DllImport(libraryPath, EntryPoint = "LLVMIsThreadLocal", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsThreadLocal(LLVMValueRef @GlobalVar);

        [DllImport(libraryPath, EntryPoint = "LLVMSetThreadLocal", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetThreadLocal(LLVMValueRef @GlobalVar, LLVMBool @IsThreadLocal);

        [DllImport(libraryPath, EntryPoint = "LLVMIsGlobalConstant", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsGlobalConstant(LLVMValueRef @GlobalVar);

        [DllImport(libraryPath, EntryPoint = "LLVMSetGlobalConstant", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetGlobalConstant(LLVMValueRef @GlobalVar, LLVMBool @IsConstant);

        [DllImport(libraryPath, EntryPoint = "LLVMGetThreadLocalMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMThreadLocalMode GetThreadLocalMode(LLVMValueRef @GlobalVar);

        [DllImport(libraryPath, EntryPoint = "LLVMSetThreadLocalMode", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetThreadLocalMode(LLVMValueRef @GlobalVar, LLVMThreadLocalMode @Mode);

        [DllImport(libraryPath, EntryPoint = "LLVMIsExternallyInitialized", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsExternallyInitialized(LLVMValueRef @GlobalVar);

        [DllImport(libraryPath, EntryPoint = "LLVMSetExternallyInitialized", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetExternallyInitialized(LLVMValueRef @GlobalVar, LLVMBool @IsExtInit);

        [DllImport(libraryPath, EntryPoint = "LLVMAddAlias", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef AddAlias(LLVMModuleRef @M, LLVMTypeRef @Ty, LLVMValueRef @Aliasee, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMDeleteFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DeleteFunction(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMGetIntrinsicID", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetIntrinsicID(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMGetFunctionCallConv", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetFunctionCallConv(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMSetFunctionCallConv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetFunctionCallConv(LLVMValueRef @Fn, uint @CC);

        [DllImport(libraryPath, EntryPoint = "LLVMGetGC", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetGC(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMSetGC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetGC(LLVMValueRef @Fn, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMAddFunctionAttr", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddFunctionAttr(LLVMValueRef @Fn, LLVMAttribute @PA);

        [DllImport(libraryPath, EntryPoint = "LLVMAddTargetDependentFunctionAttr", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddTargetDependentFunctionAttr(LLVMValueRef @Fn, [MarshalAs(UnmanagedType.LPStr)] string @A, [MarshalAs(UnmanagedType.LPStr)] string @V);

        [DllImport(libraryPath, EntryPoint = "LLVMGetFunctionAttr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMAttribute GetFunctionAttr(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMRemoveFunctionAttr", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RemoveFunctionAttr(LLVMValueRef @Fn, LLVMAttribute @PA);

        [DllImport(libraryPath, EntryPoint = "LLVMCountParams", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint CountParams(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMGetParams", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetParams(LLVMValueRef @Fn, out LLVMValueRef @Params);

        [DllImport(libraryPath, EntryPoint = "LLVMGetParam", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetParam(LLVMValueRef @Fn, uint @Index);

        [DllImport(libraryPath, EntryPoint = "LLVMGetParamParent", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetParamParent(LLVMValueRef @Inst);

        [DllImport(libraryPath, EntryPoint = "LLVMGetFirstParam", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetFirstParam(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMGetLastParam", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetLastParam(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMGetNextParam", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetNextParam(LLVMValueRef @Arg);

        [DllImport(libraryPath, EntryPoint = "LLVMGetPreviousParam", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetPreviousParam(LLVMValueRef @Arg);

        [DllImport(libraryPath, EntryPoint = "LLVMAddAttribute", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddAttribute(LLVMValueRef @Arg, LLVMAttribute @PA);

        [DllImport(libraryPath, EntryPoint = "LLVMRemoveAttribute", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RemoveAttribute(LLVMValueRef @Arg, LLVMAttribute @PA);

        [DllImport(libraryPath, EntryPoint = "LLVMGetAttribute", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMAttribute GetAttribute(LLVMValueRef @Arg);

        [DllImport(libraryPath, EntryPoint = "LLVMSetParamAlignment", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetParamAlignment(LLVMValueRef @Arg, uint @align);

        [DllImport(libraryPath, EntryPoint = "LLVMMDStringInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef MDStringInContext(LLVMContextRef @C, [MarshalAs(UnmanagedType.LPStr)] string @Str, uint @SLen);

        [DllImport(libraryPath, EntryPoint = "LLVMMDString", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef MDString([MarshalAs(UnmanagedType.LPStr)] string @Str, uint @SLen);

        [DllImport(libraryPath, EntryPoint = "LLVMMDNodeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef MDNodeInContext(LLVMContextRef @C, out LLVMValueRef @Vals, uint @Count);

        [DllImport(libraryPath, EntryPoint = "LLVMMDNode", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef MDNode(out LLVMValueRef @Vals, uint @Count);

        [DllImport(libraryPath, EntryPoint = "LLVMGetMDString", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetMDString(LLVMValueRef @V, out uint @Len);

        [DllImport(libraryPath, EntryPoint = "LLVMGetMDNodeNumOperands", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetMDNodeNumOperands(LLVMValueRef @V);

        [DllImport(libraryPath, EntryPoint = "LLVMGetMDNodeOperands", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetMDNodeOperands(LLVMValueRef @V, out LLVMValueRef @Dest);

        [DllImport(libraryPath, EntryPoint = "LLVMBasicBlockAsValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BasicBlockAsValue(LLVMBasicBlockRef @BB);

        [DllImport(libraryPath, EntryPoint = "LLVMValueIsBasicBlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool ValueIsBasicBlock(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMValueAsBasicBlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef ValueAsBasicBlock(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMGetBasicBlockParent", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetBasicBlockParent(LLVMBasicBlockRef @BB);

        [DllImport(libraryPath, EntryPoint = "LLVMGetBasicBlockTerminator", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetBasicBlockTerminator(LLVMBasicBlockRef @BB);

        [DllImport(libraryPath, EntryPoint = "LLVMCountBasicBlocks", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint CountBasicBlocks(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMGetBasicBlocks", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetBasicBlocks(LLVMValueRef @Fn, out LLVMBasicBlockRef @BasicBlocks);

        [DllImport(libraryPath, EntryPoint = "LLVMGetFirstBasicBlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef GetFirstBasicBlock(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMGetLastBasicBlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef GetLastBasicBlock(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMGetNextBasicBlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef GetNextBasicBlock(LLVMBasicBlockRef @BB);

        [DllImport(libraryPath, EntryPoint = "LLVMGetPreviousBasicBlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef GetPreviousBasicBlock(LLVMBasicBlockRef @BB);

        [DllImport(libraryPath, EntryPoint = "LLVMGetEntryBasicBlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef GetEntryBasicBlock(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMAppendBasicBlockInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef AppendBasicBlockInContext(LLVMContextRef @C, LLVMValueRef @Fn, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMAppendBasicBlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef AppendBasicBlock(LLVMValueRef @Fn, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMInsertBasicBlockInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef InsertBasicBlockInContext(LLVMContextRef @C, LLVMBasicBlockRef @BB, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMInsertBasicBlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef InsertBasicBlock(LLVMBasicBlockRef @InsertBeforeBB, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMDeleteBasicBlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DeleteBasicBlock(LLVMBasicBlockRef @BB);

        [DllImport(libraryPath, EntryPoint = "LLVMRemoveBasicBlockFromParent", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RemoveBasicBlockFromParent(LLVMBasicBlockRef @BB);

        [DllImport(libraryPath, EntryPoint = "LLVMMoveBasicBlockBefore", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MoveBasicBlockBefore(LLVMBasicBlockRef @BB, LLVMBasicBlockRef @MovePos);

        [DllImport(libraryPath, EntryPoint = "LLVMMoveBasicBlockAfter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MoveBasicBlockAfter(LLVMBasicBlockRef @BB, LLVMBasicBlockRef @MovePos);

        [DllImport(libraryPath, EntryPoint = "LLVMGetFirstInstruction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetFirstInstruction(LLVMBasicBlockRef @BB);

        [DllImport(libraryPath, EntryPoint = "LLVMGetLastInstruction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetLastInstruction(LLVMBasicBlockRef @BB);

        [DllImport(libraryPath, EntryPoint = "LLVMHasMetadata", CallingConvention = CallingConvention.Cdecl)]
        public static extern int HasMetadata(LLVMValueRef @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMGetMetadata", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetMetadata(LLVMValueRef @Val, uint @KindID);

        [DllImport(libraryPath, EntryPoint = "LLVMSetMetadata", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetMetadata(LLVMValueRef @Val, uint @KindID, LLVMValueRef @Node);

        [DllImport(libraryPath, EntryPoint = "LLVMGetInstructionParent", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef GetInstructionParent(LLVMValueRef @Inst);

        [DllImport(libraryPath, EntryPoint = "LLVMGetNextInstruction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetNextInstruction(LLVMValueRef @Inst);

        [DllImport(libraryPath, EntryPoint = "LLVMGetPreviousInstruction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetPreviousInstruction(LLVMValueRef @Inst);

        [DllImport(libraryPath, EntryPoint = "LLVMInstructionEraseFromParent", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InstructionEraseFromParent(LLVMValueRef @Inst);

        [DllImport(libraryPath, EntryPoint = "LLVMGetInstructionOpcode", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMOpcode GetInstructionOpcode(LLVMValueRef @Inst);

        [DllImport(libraryPath, EntryPoint = "LLVMGetICmpPredicate", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMIntPredicate GetICmpPredicate(LLVMValueRef @Inst);

        [DllImport(libraryPath, EntryPoint = "LLVMGetFCmpPredicate", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMRealPredicate GetFCmpPredicate(LLVMValueRef @Inst);

        [DllImport(libraryPath, EntryPoint = "LLVMInstructionClone", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef InstructionClone(LLVMValueRef @Inst);

        [DllImport(libraryPath, EntryPoint = "LLVMSetInstructionCallConv", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetInstructionCallConv(LLVMValueRef @Instr, uint @CC);

        [DllImport(libraryPath, EntryPoint = "LLVMGetInstructionCallConv", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetInstructionCallConv(LLVMValueRef @Instr);

        [DllImport(libraryPath, EntryPoint = "LLVMAddInstrAttribute", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddInstrAttribute(LLVMValueRef @Instr, uint @index, LLVMAttribute @param2);

        [DllImport(libraryPath, EntryPoint = "LLVMRemoveInstrAttribute", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RemoveInstrAttribute(LLVMValueRef @Instr, uint @index, LLVMAttribute @param2);

        [DllImport(libraryPath, EntryPoint = "LLVMSetInstrParamAlignment", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetInstrParamAlignment(LLVMValueRef @Instr, uint @index, uint @align);

        [DllImport(libraryPath, EntryPoint = "LLVMIsTailCall", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsTailCall(LLVMValueRef @CallInst);

        [DllImport(libraryPath, EntryPoint = "LLVMSetTailCall", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTailCall(LLVMValueRef @CallInst, LLVMBool @IsTailCall);

        [DllImport(libraryPath, EntryPoint = "LLVMGetNumSuccessors", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GetNumSuccessors(LLVMValueRef @Term);

        [DllImport(libraryPath, EntryPoint = "LLVMGetSuccessor", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef GetSuccessor(LLVMValueRef @Term, uint @i);

        [DllImport(libraryPath, EntryPoint = "LLVMSetSuccessor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetSuccessor(LLVMValueRef @Term, uint @i, LLVMBasicBlockRef @block);

        [DllImport(libraryPath, EntryPoint = "LLVMIsConditional", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsConditional(LLVMValueRef @Branch);

        [DllImport(libraryPath, EntryPoint = "LLVMGetCondition", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetCondition(LLVMValueRef @Branch);

        [DllImport(libraryPath, EntryPoint = "LLVMSetCondition", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetCondition(LLVMValueRef @Branch, LLVMValueRef @Cond);

        [DllImport(libraryPath, EntryPoint = "LLVMGetSwitchDefaultDest", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef GetSwitchDefaultDest(LLVMValueRef @SwitchInstr);

        [DllImport(libraryPath, EntryPoint = "LLVMAddIncoming", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddIncoming(LLVMValueRef @PhiNode, out LLVMValueRef @IncomingValues, out LLVMBasicBlockRef @IncomingBlocks, uint @Count);

        [DllImport(libraryPath, EntryPoint = "LLVMCountIncoming", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint CountIncoming(LLVMValueRef @PhiNode);

        [DllImport(libraryPath, EntryPoint = "LLVMGetIncomingValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetIncomingValue(LLVMValueRef @PhiNode, uint @Index);

        [DllImport(libraryPath, EntryPoint = "LLVMGetIncomingBlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef GetIncomingBlock(LLVMValueRef @PhiNode, uint @Index);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateBuilderInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBuilderRef CreateBuilderInContext(LLVMContextRef @C);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateBuilder", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBuilderRef CreateBuilder();

        [DllImport(libraryPath, EntryPoint = "LLVMPositionBuilder", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PositionBuilder(LLVMBuilderRef @Builder, LLVMBasicBlockRef @Block, LLVMValueRef @Instr);

        [DllImport(libraryPath, EntryPoint = "LLVMPositionBuilderBefore", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PositionBuilderBefore(LLVMBuilderRef @Builder, LLVMValueRef @Instr);

        [DllImport(libraryPath, EntryPoint = "LLVMPositionBuilderAtEnd", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PositionBuilderAtEnd(LLVMBuilderRef @Builder, LLVMBasicBlockRef @Block);

        [DllImport(libraryPath, EntryPoint = "LLVMGetInsertBlock", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBasicBlockRef GetInsertBlock(LLVMBuilderRef @Builder);

        [DllImport(libraryPath, EntryPoint = "LLVMClearInsertionPosition", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ClearInsertionPosition(LLVMBuilderRef @Builder);

        [DllImport(libraryPath, EntryPoint = "LLVMInsertIntoBuilder", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InsertIntoBuilder(LLVMBuilderRef @Builder, LLVMValueRef @Instr);

        [DllImport(libraryPath, EntryPoint = "LLVMInsertIntoBuilderWithName", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InsertIntoBuilderWithName(LLVMBuilderRef @Builder, LLVMValueRef @Instr, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeBuilder", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeBuilder(LLVMBuilderRef @Builder);

        [DllImport(libraryPath, EntryPoint = "LLVMSetCurrentDebugLocation", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetCurrentDebugLocation(LLVMBuilderRef @Builder, LLVMValueRef @L);

        [DllImport(libraryPath, EntryPoint = "LLVMGetCurrentDebugLocation", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef GetCurrentDebugLocation(LLVMBuilderRef @Builder);

        [DllImport(libraryPath, EntryPoint = "LLVMSetInstDebugLocation", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetInstDebugLocation(LLVMBuilderRef @Builder, LLVMValueRef @Inst);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildRetVoid", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildRetVoid(LLVMBuilderRef @param0);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildRet", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildRet(LLVMBuilderRef @param0, LLVMValueRef @V);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildAggregateRet", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildAggregateRet(LLVMBuilderRef @param0, out LLVMValueRef @RetVals, uint @N);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildBr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildBr(LLVMBuilderRef @param0, LLVMBasicBlockRef @Dest);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildCondBr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildCondBr(LLVMBuilderRef @param0, LLVMValueRef @If, LLVMBasicBlockRef @Then, LLVMBasicBlockRef @Else);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildSwitch", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildSwitch(LLVMBuilderRef @param0, LLVMValueRef @V, LLVMBasicBlockRef @Else, uint @NumCases);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildIndirectBr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildIndirectBr(LLVMBuilderRef @B, LLVMValueRef @Addr, uint @NumDests);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildInvoke", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildInvoke(LLVMBuilderRef @param0, LLVMValueRef @Fn, out LLVMValueRef @Args, uint @NumArgs, LLVMBasicBlockRef @Then, LLVMBasicBlockRef @Catch, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildLandingPad", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildLandingPad(LLVMBuilderRef @B, LLVMTypeRef @Ty, LLVMValueRef @PersFn, uint @NumClauses, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildResume", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildResume(LLVMBuilderRef @B, LLVMValueRef @Exn);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildUnreachable", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildUnreachable(LLVMBuilderRef @param0);

        [DllImport(libraryPath, EntryPoint = "LLVMAddCase", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddCase(LLVMValueRef @Switch, LLVMValueRef @OnVal, LLVMBasicBlockRef @Dest);

        [DllImport(libraryPath, EntryPoint = "LLVMAddDestination", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddDestination(LLVMValueRef @IndirectBr, LLVMBasicBlockRef @Dest);

        [DllImport(libraryPath, EntryPoint = "LLVMAddClause", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddClause(LLVMValueRef @LandingPad, LLVMValueRef @ClauseVal);

        [DllImport(libraryPath, EntryPoint = "LLVMSetCleanup", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetCleanup(LLVMValueRef @LandingPad, LLVMBool @Val);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildAdd", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildAdd(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildNSWAdd", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildNSWAdd(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildNUWAdd", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildNUWAdd(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFAdd", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFAdd(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildSub", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildSub(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildNSWSub", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildNSWSub(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildNUWSub", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildNUWSub(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFSub", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFSub(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildMul", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildMul(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildNSWMul", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildNSWMul(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildNUWMul", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildNUWMul(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFMul", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFMul(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildUDiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildUDiv(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildSDiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildSDiv(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildExactSDiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildExactSDiv(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFDiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFDiv(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildURem", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildURem(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildSRem", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildSRem(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFRem", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFRem(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildShl", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildShl(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildLShr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildLShr(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildAShr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildAShr(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildAnd", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildAnd(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildOr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildOr(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildXor", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildXor(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildBinOp", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildBinOp(LLVMBuilderRef @B, LLVMOpcode @Op, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildNeg", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildNeg(LLVMBuilderRef @param0, LLVMValueRef @V, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildNSWNeg", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildNSWNeg(LLVMBuilderRef @B, LLVMValueRef @V, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildNUWNeg", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildNUWNeg(LLVMBuilderRef @B, LLVMValueRef @V, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFNeg", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFNeg(LLVMBuilderRef @param0, LLVMValueRef @V, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildNot", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildNot(LLVMBuilderRef @param0, LLVMValueRef @V, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildMalloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildMalloc(LLVMBuilderRef @param0, LLVMTypeRef @Ty, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildArrayMalloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildArrayMalloc(LLVMBuilderRef @param0, LLVMTypeRef @Ty, LLVMValueRef @Val, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildAlloca", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildAlloca(LLVMBuilderRef @param0, LLVMTypeRef @Ty, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildArrayAlloca", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildArrayAlloca(LLVMBuilderRef @param0, LLVMTypeRef @Ty, LLVMValueRef @Val, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFree", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFree(LLVMBuilderRef @param0, LLVMValueRef @PointerVal);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildLoad", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildLoad(LLVMBuilderRef @param0, LLVMValueRef @PointerVal, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildStore", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildStore(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMValueRef @Ptr);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildGEP", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildGEP(LLVMBuilderRef @B, LLVMValueRef @Pointer, out LLVMValueRef @Indices, uint @NumIndices, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildInBoundsGEP", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildInBoundsGEP(LLVMBuilderRef @B, LLVMValueRef @Pointer, out LLVMValueRef @Indices, uint @NumIndices, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildStructGEP", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildStructGEP(LLVMBuilderRef @B, LLVMValueRef @Pointer, uint @Idx, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildGlobalString", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildGlobalString(LLVMBuilderRef @B, [MarshalAs(UnmanagedType.LPStr)] string @Str, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildGlobalStringPtr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildGlobalStringPtr(LLVMBuilderRef @B, [MarshalAs(UnmanagedType.LPStr)] string @Str, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMGetVolatile", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool GetVolatile(LLVMValueRef @MemoryAccessInst);

        [DllImport(libraryPath, EntryPoint = "LLVMSetVolatile", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetVolatile(LLVMValueRef @MemoryAccessInst, LLVMBool @IsVolatile);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildTrunc", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildTrunc(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildZExt", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildZExt(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildSExt", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildSExt(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFPToUI", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFPToUI(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFPToSI", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFPToSI(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildUIToFP", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildUIToFP(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildSIToFP", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildSIToFP(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFPTrunc", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFPTrunc(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFPExt", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFPExt(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildPtrToInt", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildPtrToInt(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildIntToPtr", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildIntToPtr(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildBitCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildBitCast(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildAddrSpaceCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildAddrSpaceCast(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildZExtOrBitCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildZExtOrBitCast(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildSExtOrBitCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildSExtOrBitCast(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildTruncOrBitCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildTruncOrBitCast(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildCast(LLVMBuilderRef @B, LLVMOpcode @Op, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildPointerCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildPointerCast(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildIntCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildIntCast(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFPCast", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFPCast(LLVMBuilderRef @param0, LLVMValueRef @Val, LLVMTypeRef @DestTy, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildICmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildICmp(LLVMBuilderRef @param0, LLVMIntPredicate @Op, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFCmp", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFCmp(LLVMBuilderRef @param0, LLVMRealPredicate @Op, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildPhi", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildPhi(LLVMBuilderRef @param0, LLVMTypeRef @Ty, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildCall", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildCall(LLVMBuilderRef @param0, LLVMValueRef @Fn, out LLVMValueRef @Args, uint @NumArgs, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildSelect", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildSelect(LLVMBuilderRef @param0, LLVMValueRef @If, LLVMValueRef @Then, LLVMValueRef @Else, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildVAArg", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildVAArg(LLVMBuilderRef @param0, LLVMValueRef @List, LLVMTypeRef @Ty, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildExtractElement", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildExtractElement(LLVMBuilderRef @param0, LLVMValueRef @VecVal, LLVMValueRef @Index, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildInsertElement", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildInsertElement(LLVMBuilderRef @param0, LLVMValueRef @VecVal, LLVMValueRef @EltVal, LLVMValueRef @Index, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildShuffleVector", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildShuffleVector(LLVMBuilderRef @param0, LLVMValueRef @V1, LLVMValueRef @V2, LLVMValueRef @Mask, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildExtractValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildExtractValue(LLVMBuilderRef @param0, LLVMValueRef @AggVal, uint @Index, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildInsertValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildInsertValue(LLVMBuilderRef @param0, LLVMValueRef @AggVal, LLVMValueRef @EltVal, uint @Index, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildIsNull", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildIsNull(LLVMBuilderRef @param0, LLVMValueRef @Val, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildIsNotNull", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildIsNotNull(LLVMBuilderRef @param0, LLVMValueRef @Val, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildPtrDiff", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildPtrDiff(LLVMBuilderRef @param0, LLVMValueRef @LHS, LLVMValueRef @RHS, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildFence", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildFence(LLVMBuilderRef @B, LLVMAtomicOrdering @ordering, LLVMBool @singleThread, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMBuildAtomicRMW", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMValueRef BuildAtomicRMW(LLVMBuilderRef @B, LLVMAtomicRMWBinOp @op, LLVMValueRef @PTR, LLVMValueRef @Val, LLVMAtomicOrdering @ordering, LLVMBool @singleThread);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateModuleProviderForExistingModule", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMModuleProviderRef CreateModuleProviderForExistingModule(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeModuleProvider", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeModuleProvider(LLVMModuleProviderRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateMemoryBufferWithContentsOfFile", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool CreateMemoryBufferWithContentsOfFile([MarshalAs(UnmanagedType.LPStr)] string @Path, out LLVMMemoryBufferRef @OutMemBuf, out IntPtr @OutMessage);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateMemoryBufferWithSTDIN", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool CreateMemoryBufferWithSTDIN(out LLVMMemoryBufferRef @OutMemBuf, out IntPtr @OutMessage);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateMemoryBufferWithMemoryRange", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMMemoryBufferRef CreateMemoryBufferWithMemoryRange([MarshalAs(UnmanagedType.LPStr)] string @InputData, int @InputDataLength, [MarshalAs(UnmanagedType.LPStr)] string @BufferName, LLVMBool @RequiresNullTerminator);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateMemoryBufferWithMemoryRangeCopy", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMMemoryBufferRef CreateMemoryBufferWithMemoryRangeCopy([MarshalAs(UnmanagedType.LPStr)] string @InputData, int @InputDataLength, [MarshalAs(UnmanagedType.LPStr)] string @BufferName);

        [DllImport(libraryPath, EntryPoint = "LLVMGetBufferStart", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetBufferStart(LLVMMemoryBufferRef @MemBuf);

        [DllImport(libraryPath, EntryPoint = "LLVMGetBufferSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetBufferSize(LLVMMemoryBufferRef @MemBuf);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeMemoryBuffer", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeMemoryBuffer(LLVMMemoryBufferRef @MemBuf);

        [DllImport(libraryPath, EntryPoint = "LLVMGetGlobalPassRegistry", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMPassRegistryRef GetGlobalPassRegistry();

        [DllImport(libraryPath, EntryPoint = "LLVMCreatePassManager", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMPassManagerRef CreatePassManager();

        [DllImport(libraryPath, EntryPoint = "LLVMCreateFunctionPassManagerForModule", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMPassManagerRef CreateFunctionPassManagerForModule(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateFunctionPassManager", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMPassManagerRef CreateFunctionPassManager(LLVMModuleProviderRef @MP);

        [DllImport(libraryPath, EntryPoint = "LLVMRunPassManager", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool RunPassManager(LLVMPassManagerRef @PM, LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeFunctionPassManager", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool InitializeFunctionPassManager(LLVMPassManagerRef @FPM);

        [DllImport(libraryPath, EntryPoint = "LLVMRunFunctionPassManager", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool RunFunctionPassManager(LLVMPassManagerRef @FPM, LLVMValueRef @F);

        [DllImport(libraryPath, EntryPoint = "LLVMFinalizeFunctionPassManager", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool FinalizeFunctionPassManager(LLVMPassManagerRef @FPM);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposePassManager", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposePassManager(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMStartMultithreaded", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool StartMultithreaded();

        [DllImport(libraryPath, EntryPoint = "LLVMStopMultithreaded", CallingConvention = CallingConvention.Cdecl)]
        public static extern void StopMultithreaded();

        [DllImport(libraryPath, EntryPoint = "LLVMIsMultithreaded", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsMultithreaded();

        [DllImport(libraryPath, EntryPoint = "LLVMVerifyModule", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool VerifyModule(LLVMModuleRef @M, LLVMVerifierFailureAction @Action, out IntPtr @OutMessage);

        [DllImport(libraryPath, EntryPoint = "LLVMVerifyFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool VerifyFunction(LLVMValueRef @Fn, LLVMVerifierFailureAction @Action);

        [DllImport(libraryPath, EntryPoint = "LLVMViewFunctionCFG", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ViewFunctionCFG(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMViewFunctionCFGOnly", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ViewFunctionCFGOnly(LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMParseBitcode", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool ParseBitcode(LLVMMemoryBufferRef @MemBuf, out LLVMModuleRef @OutModule, out IntPtr @OutMessage);

        [DllImport(libraryPath, EntryPoint = "LLVMParseBitcodeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool ParseBitcodeInContext(LLVMContextRef @ContextRef, LLVMMemoryBufferRef @MemBuf, out LLVMModuleRef @OutModule, out IntPtr @OutMessage);

        [DllImport(libraryPath, EntryPoint = "LLVMGetBitcodeModuleInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool GetBitcodeModuleInContext(LLVMContextRef @ContextRef, LLVMMemoryBufferRef @MemBuf, out LLVMModuleRef @OutM, out IntPtr @OutMessage);

        [DllImport(libraryPath, EntryPoint = "LLVMGetBitcodeModule", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool GetBitcodeModule(LLVMMemoryBufferRef @MemBuf, out LLVMModuleRef @OutM, out IntPtr @OutMessage);

        [DllImport(libraryPath, EntryPoint = "LLVMGetBitcodeModuleProviderInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool GetBitcodeModuleProviderInContext(LLVMContextRef @ContextRef, LLVMMemoryBufferRef @MemBuf, out LLVMModuleProviderRef @OutMP, out IntPtr @OutMessage);

        [DllImport(libraryPath, EntryPoint = "LLVMGetBitcodeModuleProvider", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool GetBitcodeModuleProvider(LLVMMemoryBufferRef @MemBuf, out LLVMModuleProviderRef @OutMP, out IntPtr @OutMessage);

        [DllImport(libraryPath, EntryPoint = "LLVMWriteBitcodeToFile", CallingConvention = CallingConvention.Cdecl)]
        public static extern int WriteBitcodeToFile(LLVMModuleRef @M, [MarshalAs(UnmanagedType.LPStr)] string @Path);

        [DllImport(libraryPath, EntryPoint = "LLVMWriteBitcodeToFD", CallingConvention = CallingConvention.Cdecl)]
        public static extern int WriteBitcodeToFD(LLVMModuleRef @M, int @FD, int @ShouldClose, int @Unbuffered);

        [DllImport(libraryPath, EntryPoint = "LLVMWriteBitcodeToFileHandle", CallingConvention = CallingConvention.Cdecl)]
        public static extern int WriteBitcodeToFileHandle(LLVMModuleRef @M, int @Handle);

        [DllImport(libraryPath, EntryPoint = "LLVMWriteBitcodeToMemoryBuffer", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMMemoryBufferRef WriteBitcodeToMemoryBuffer(LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateDisasm", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMDisasmContextRef CreateDisasm([MarshalAs(UnmanagedType.LPStr)] string @TripleName, IntPtr @DisInfo, int @TagType, LLVMOpInfoCallback @GetOpInfo, LLVMSymbolLookupCallback @SymbolLookUp);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateDisasmCPU", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMDisasmContextRef CreateDisasmCPU([MarshalAs(UnmanagedType.LPStr)] string @Triple, [MarshalAs(UnmanagedType.LPStr)] string @CPU, IntPtr @DisInfo, int @TagType, LLVMOpInfoCallback @GetOpInfo, LLVMSymbolLookupCallback @SymbolLookUp);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateDisasmCPUFeatures", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMDisasmContextRef CreateDisasmCPUFeatures([MarshalAs(UnmanagedType.LPStr)] string @Triple, [MarshalAs(UnmanagedType.LPStr)] string @CPU, [MarshalAs(UnmanagedType.LPStr)] string @Features, IntPtr @DisInfo, int @TagType, LLVMOpInfoCallback @GetOpInfo, LLVMSymbolLookupCallback @SymbolLookUp);

        [DllImport(libraryPath, EntryPoint = "LLVMSetDisasmOptions", CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetDisasmOptions(LLVMDisasmContextRef @DC, int @Options);

        [DllImport(libraryPath, EntryPoint = "LLVMDisasmDispose", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisasmDispose(LLVMDisasmContextRef @DC);

        [DllImport(libraryPath, EntryPoint = "LLVMDisasmInstruction", CallingConvention = CallingConvention.Cdecl)]
        public static extern int DisasmInstruction(LLVMDisasmContextRef @DC, out char @Bytes, int @BytesSize, int @PC, IntPtr @OutString, int @OutStringSize);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeR600TargetInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeR600TargetInfo();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeSystemZTargetInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeSystemZTargetInfo();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeHexagonTargetInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeHexagonTargetInfo();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeNVPTXTargetInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeNVPTXTargetInfo();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeCppBackendTargetInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeCppBackendTargetInfo();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeMSP430TargetInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeMSP430TargetInfo();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeXCoreTargetInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeXCoreTargetInfo();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeMipsTargetInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeMipsTargetInfo();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeAArch64TargetInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeAArch64TargetInfo();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeARMTargetInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeARMTargetInfo();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializePowerPCTargetInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializePowerPCTargetInfo();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeSparcTargetInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeSparcTargetInfo();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeX86TargetInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeX86TargetInfo();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeR600Target", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeR600Target();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeSystemZTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeSystemZTarget();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeHexagonTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeHexagonTarget();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeNVPTXTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeNVPTXTarget();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeCppBackendTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeCppBackendTarget();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeMSP430Target", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeMSP430Target();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeXCoreTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeXCoreTarget();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeMipsTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeMipsTarget();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeAArch64Target", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeAArch64Target();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeARMTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeARMTarget();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializePowerPCTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializePowerPCTarget();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeSparcTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeSparcTarget();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeX86Target", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeX86Target();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeR600TargetMC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeR600TargetMC();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeSystemZTargetMC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeSystemZTargetMC();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeHexagonTargetMC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeHexagonTargetMC();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeNVPTXTargetMC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeNVPTXTargetMC();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeCppBackendTargetMC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeCppBackendTargetMC();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeMSP430TargetMC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeMSP430TargetMC();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeXCoreTargetMC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeXCoreTargetMC();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeMipsTargetMC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeMipsTargetMC();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeAArch64TargetMC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeAArch64TargetMC();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeARMTargetMC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeARMTargetMC();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializePowerPCTargetMC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializePowerPCTargetMC();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeSparcTargetMC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeSparcTargetMC();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeX86TargetMC", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeX86TargetMC();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeR600AsmPrinter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeR600AsmPrinter();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeSystemZAsmPrinter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeSystemZAsmPrinter();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeHexagonAsmPrinter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeHexagonAsmPrinter();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeNVPTXAsmPrinter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeNVPTXAsmPrinter();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeMSP430AsmPrinter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeMSP430AsmPrinter();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeXCoreAsmPrinter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeXCoreAsmPrinter();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeMipsAsmPrinter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeMipsAsmPrinter();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeAArch64AsmPrinter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeAArch64AsmPrinter();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeARMAsmPrinter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeARMAsmPrinter();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializePowerPCAsmPrinter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializePowerPCAsmPrinter();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeSparcAsmPrinter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeSparcAsmPrinter();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeX86AsmPrinter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeX86AsmPrinter();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeR600AsmParser", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeR600AsmParser();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeSystemZAsmParser", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeSystemZAsmParser();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeMipsAsmParser", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeMipsAsmParser();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeAArch64AsmParser", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeAArch64AsmParser();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeARMAsmParser", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeARMAsmParser();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializePowerPCAsmParser", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializePowerPCAsmParser();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeSparcAsmParser", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeSparcAsmParser();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeX86AsmParser", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeX86AsmParser();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeSystemZDisassembler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeSystemZDisassembler();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeHexagonDisassembler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeHexagonDisassembler();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeXCoreDisassembler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeXCoreDisassembler();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeMipsDisassembler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeMipsDisassembler();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeAArch64Disassembler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeAArch64Disassembler();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeARMDisassembler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeARMDisassembler();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializePowerPCDisassembler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializePowerPCDisassembler();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeSparcDisassembler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeSparcDisassembler();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeX86Disassembler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeX86Disassembler();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeAllTargetInfos", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeAllTargetInfos();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeAllTargets", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeAllTargets();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeAllTargetMCs", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeAllTargetMCs();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeAllAsmPrinters", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeAllAsmPrinters();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeAllAsmParsers", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeAllAsmParsers();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeAllDisassemblers", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeAllDisassemblers();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeNativeTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool InitializeNativeTarget();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeNativeAsmParser", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool InitializeNativeAsmParser();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeNativeAsmPrinter", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool InitializeNativeAsmPrinter();

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeNativeDisassembler", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool InitializeNativeDisassembler();

        [DllImport(libraryPath, EntryPoint = "LLVMCreateTargetData", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTargetDataRef CreateTargetData([MarshalAs(UnmanagedType.LPStr)] string @StringRep);

        [DllImport(libraryPath, EntryPoint = "LLVMAddTargetData", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddTargetData(LLVMTargetDataRef @TD, LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddTargetLibraryInfo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddTargetLibraryInfo(LLVMTargetLibraryInfoRef @TLI, LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMCopyStringRepOfTargetData", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CopyStringRepOfTargetData(LLVMTargetDataRef @TD);

        [DllImport(libraryPath, EntryPoint = "LLVMByteOrder", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMByteOrdering ByteOrder(LLVMTargetDataRef @TD);

        [DllImport(libraryPath, EntryPoint = "LLVMPointerSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint PointerSize(LLVMTargetDataRef @TD);

        [DllImport(libraryPath, EntryPoint = "LLVMPointerSizeForAS", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint PointerSizeForAS(LLVMTargetDataRef @TD, uint @AS);

        [DllImport(libraryPath, EntryPoint = "LLVMIntPtrType", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef IntPtrType(LLVMTargetDataRef @TD);

        [DllImport(libraryPath, EntryPoint = "LLVMIntPtrTypeForAS", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef IntPtrTypeForAS(LLVMTargetDataRef @TD, uint @AS);

        [DllImport(libraryPath, EntryPoint = "LLVMIntPtrTypeInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef IntPtrTypeInContext(LLVMContextRef @C, LLVMTargetDataRef @TD);

        [DllImport(libraryPath, EntryPoint = "LLVMIntPtrTypeForASInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTypeRef IntPtrTypeForASInContext(LLVMContextRef @C, LLVMTargetDataRef @TD, uint @AS);

        [DllImport(libraryPath, EntryPoint = "LLVMSizeOfTypeInBits", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong SizeOfTypeInBits(LLVMTargetDataRef @TD, LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMStoreSizeOfType", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong StoreSizeOfType(LLVMTargetDataRef @TD, LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMABISizeOfType", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong ABISizeOfType(LLVMTargetDataRef @TD, LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMABIAlignmentOfType", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ABIAlignmentOfType(LLVMTargetDataRef @TD, LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMCallFrameAlignmentOfType", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint CallFrameAlignmentOfType(LLVMTargetDataRef @TD, LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMPreferredAlignmentOfType", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint PreferredAlignmentOfType(LLVMTargetDataRef @TD, LLVMTypeRef @Ty);

        [DllImport(libraryPath, EntryPoint = "LLVMPreferredAlignmentOfGlobal", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint PreferredAlignmentOfGlobal(LLVMTargetDataRef @TD, LLVMValueRef @GlobalVar);

        [DllImport(libraryPath, EntryPoint = "LLVMElementAtOffset", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ElementAtOffset(LLVMTargetDataRef @TD, LLVMTypeRef @StructTy, ulong @Offset);

        [DllImport(libraryPath, EntryPoint = "LLVMOffsetOfElement", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong OffsetOfElement(LLVMTargetDataRef @TD, LLVMTypeRef @StructTy, uint @Element);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeTargetData", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeTargetData(LLVMTargetDataRef @TD);

        [DllImport(libraryPath, EntryPoint = "LLVMGetFirstTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTargetRef GetFirstTarget();

        [DllImport(libraryPath, EntryPoint = "LLVMGetNextTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTargetRef GetNextTarget(LLVMTargetRef @T);

        [DllImport(libraryPath, EntryPoint = "LLVMGetTargetFromName", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTargetRef GetTargetFromName([MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMGetTargetFromTriple", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool GetTargetFromTriple([MarshalAs(UnmanagedType.LPStr)] string @Triple, out LLVMTargetRef @T, out IntPtr @ErrorMessage);

        [DllImport(libraryPath, EntryPoint = "LLVMGetTargetName", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetTargetName(LLVMTargetRef @T);

        [DllImport(libraryPath, EntryPoint = "LLVMGetTargetDescription", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetTargetDescription(LLVMTargetRef @T);

        [DllImport(libraryPath, EntryPoint = "LLVMTargetHasJIT", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool TargetHasJIT(LLVMTargetRef @T);

        [DllImport(libraryPath, EntryPoint = "LLVMTargetHasTargetMachine", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool TargetHasTargetMachine(LLVMTargetRef @T);

        [DllImport(libraryPath, EntryPoint = "LLVMTargetHasAsmBackend", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool TargetHasAsmBackend(LLVMTargetRef @T);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateTargetMachine", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTargetMachineRef CreateTargetMachine(LLVMTargetRef @T, [MarshalAs(UnmanagedType.LPStr)] string @Triple, [MarshalAs(UnmanagedType.LPStr)] string @CPU, [MarshalAs(UnmanagedType.LPStr)] string @Features, LLVMCodeGenOptLevel @Level, LLVMRelocMode @Reloc, LLVMCodeModel @CodeModel);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeTargetMachine", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeTargetMachine(LLVMTargetMachineRef @T);

        [DllImport(libraryPath, EntryPoint = "LLVMGetTargetMachineTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTargetRef GetTargetMachineTarget(LLVMTargetMachineRef @T);

        [DllImport(libraryPath, EntryPoint = "LLVMGetTargetMachineTriple", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetTargetMachineTriple(LLVMTargetMachineRef @T);

        [DllImport(libraryPath, EntryPoint = "LLVMGetTargetMachineCPU", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetTargetMachineCPU(LLVMTargetMachineRef @T);

        [DllImport(libraryPath, EntryPoint = "LLVMGetTargetMachineFeatureString", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetTargetMachineFeatureString(LLVMTargetMachineRef @T);

        [DllImport(libraryPath, EntryPoint = "LLVMGetTargetMachineData", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTargetDataRef GetTargetMachineData(LLVMTargetMachineRef @T);

        [DllImport(libraryPath, EntryPoint = "LLVMSetTargetMachineAsmVerbosity", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetTargetMachineAsmVerbosity(LLVMTargetMachineRef @T, LLVMBool @VerboseAsm);

        [DllImport(libraryPath, EntryPoint = "LLVMTargetMachineEmitToFile", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool TargetMachineEmitToFile(LLVMTargetMachineRef @T, LLVMModuleRef @M, IntPtr @Filename, LLVMCodeGenFileType @codegen, out IntPtr @ErrorMessage);

        [DllImport(libraryPath, EntryPoint = "LLVMTargetMachineEmitToMemoryBuffer", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool TargetMachineEmitToMemoryBuffer(LLVMTargetMachineRef @T, LLVMModuleRef @M, LLVMCodeGenFileType @codegen, out IntPtr @ErrorMessage, out LLVMMemoryBufferRef @OutMemBuf);

        [DllImport(libraryPath, EntryPoint = "LLVMGetDefaultTargetTriple", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetDefaultTargetTriple();

        [DllImport(libraryPath, EntryPoint = "LLVMAddAnalysisPasses", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddAnalysisPasses(LLVMTargetMachineRef @T, LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMLinkInMCJIT", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LinkInMCJIT();

        [DllImport(libraryPath, EntryPoint = "LLVMLinkInInterpreter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LinkInInterpreter();

        [DllImport(libraryPath, EntryPoint = "LLVMCreateGenericValueOfInt", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMGenericValueRef CreateGenericValueOfInt(LLVMTypeRef @Ty, ulong @N, LLVMBool @IsSigned);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateGenericValueOfPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMGenericValueRef CreateGenericValueOfPointer(IntPtr @P);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateGenericValueOfFloat", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMGenericValueRef CreateGenericValueOfFloat(LLVMTypeRef @Ty, double @N);

        [DllImport(libraryPath, EntryPoint = "LLVMGenericValueIntWidth", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint GenericValueIntWidth(LLVMGenericValueRef @GenValRef);

        [DllImport(libraryPath, EntryPoint = "LLVMGenericValueToInt", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong GenericValueToInt(LLVMGenericValueRef @GenVal, LLVMBool @IsSigned);

        [DllImport(libraryPath, EntryPoint = "LLVMGenericValueToPointer", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GenericValueToPointer(LLVMGenericValueRef @GenVal);

        [DllImport(libraryPath, EntryPoint = "LLVMGenericValueToFloat", CallingConvention = CallingConvention.Cdecl)]
        public static extern double GenericValueToFloat(LLVMTypeRef @TyRef, LLVMGenericValueRef @GenVal);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeGenericValue", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeGenericValue(LLVMGenericValueRef @GenVal);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateExecutionEngineForModule", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool CreateExecutionEngineForModule(out LLVMExecutionEngineRef @OutEE, LLVMModuleRef @M, out IntPtr @OutError);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateInterpreterForModule", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool CreateInterpreterForModule(out LLVMExecutionEngineRef @OutInterp, LLVMModuleRef @M, out IntPtr @OutError);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateJITCompilerForModule", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool CreateJITCompilerForModule(out LLVMExecutionEngineRef @OutJIT, LLVMModuleRef @M, uint @OptLevel, out IntPtr @OutError);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeMCJITCompilerOptions", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeMCJITCompilerOptions(out LLVMMCJITCompilerOptions @Options, int @SizeOfOptions);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateMCJITCompilerForModule", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool CreateMCJITCompilerForModule(out LLVMExecutionEngineRef @OutJIT, LLVMModuleRef @M, out LLVMMCJITCompilerOptions @Options, int @SizeOfOptions, out IntPtr @OutError);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateExecutionEngine", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool CreateExecutionEngine(out LLVMExecutionEngineRef @OutEE, LLVMModuleProviderRef @MP, out IntPtr @OutError);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateInterpreter", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool CreateInterpreter(out LLVMExecutionEngineRef @OutInterp, LLVMModuleProviderRef @MP, out IntPtr @OutError);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateJITCompiler", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool CreateJITCompiler(out LLVMExecutionEngineRef @OutJIT, LLVMModuleProviderRef @MP, uint @OptLevel, out IntPtr @OutError);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeExecutionEngine", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeExecutionEngine(LLVMExecutionEngineRef @EE);

        [DllImport(libraryPath, EntryPoint = "LLVMRunStaticConstructors", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RunStaticConstructors(LLVMExecutionEngineRef @EE);

        [DllImport(libraryPath, EntryPoint = "LLVMRunStaticDestructors", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RunStaticDestructors(LLVMExecutionEngineRef @EE);

        [DllImport(libraryPath, EntryPoint = "LLVMRunFunctionAsMain", CallingConvention = CallingConvention.Cdecl)]
        public static extern int RunFunctionAsMain(LLVMExecutionEngineRef @EE, LLVMValueRef @F, uint @ArgC, string[] @ArgV, string[] @EnvP);

        [DllImport(libraryPath, EntryPoint = "LLVMRunFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMGenericValueRef RunFunction(LLVMExecutionEngineRef @EE, LLVMValueRef @F, uint @NumArgs, out LLVMGenericValueRef @Args);

        [DllImport(libraryPath, EntryPoint = "LLVMFreeMachineCodeForFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern void FreeMachineCodeForFunction(LLVMExecutionEngineRef @EE, LLVMValueRef @F);

        [DllImport(libraryPath, EntryPoint = "LLVMAddModule", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddModule(LLVMExecutionEngineRef @EE, LLVMModuleRef @M);

        [DllImport(libraryPath, EntryPoint = "LLVMAddModuleProvider", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddModuleProvider(LLVMExecutionEngineRef @EE, LLVMModuleProviderRef @MP);

        [DllImport(libraryPath, EntryPoint = "LLVMRemoveModule", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool RemoveModule(LLVMExecutionEngineRef @EE, LLVMModuleRef @M, out LLVMModuleRef @OutMod, out IntPtr @OutError);

        [DllImport(libraryPath, EntryPoint = "LLVMRemoveModuleProvider", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool RemoveModuleProvider(LLVMExecutionEngineRef @EE, LLVMModuleProviderRef @MP, out LLVMModuleRef @OutMod, out IntPtr @OutError);

        [DllImport(libraryPath, EntryPoint = "LLVMFindFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool FindFunction(LLVMExecutionEngineRef @EE, [MarshalAs(UnmanagedType.LPStr)] string @Name, out LLVMValueRef @OutFn);

        [DllImport(libraryPath, EntryPoint = "LLVMRecompileAndRelinkFunction", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr RecompileAndRelinkFunction(LLVMExecutionEngineRef @EE, LLVMValueRef @Fn);

        [DllImport(libraryPath, EntryPoint = "LLVMGetExecutionEngineTargetData", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTargetDataRef GetExecutionEngineTargetData(LLVMExecutionEngineRef @EE);

        [DllImport(libraryPath, EntryPoint = "LLVMGetExecutionEngineTargetMachine", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMTargetMachineRef GetExecutionEngineTargetMachine(LLVMExecutionEngineRef @EE);

        [DllImport(libraryPath, EntryPoint = "LLVMAddGlobalMapping", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddGlobalMapping(LLVMExecutionEngineRef @EE, LLVMValueRef @Global, IntPtr @Addr);

        [DllImport(libraryPath, EntryPoint = "LLVMGetPointerToGlobal", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetPointerToGlobal(LLVMExecutionEngineRef @EE, LLVMValueRef @Global);

        [DllImport(libraryPath, EntryPoint = "LLVMGetGlobalValueAddress", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetGlobalValueAddress(LLVMExecutionEngineRef @EE, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMGetFunctionAddress", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetFunctionAddress(LLVMExecutionEngineRef @EE, [MarshalAs(UnmanagedType.LPStr)] string @Name);

        [DllImport(libraryPath, EntryPoint = "LLVMCreateSimpleMCJITMemoryManager", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMMCJITMemoryManagerRef CreateSimpleMCJITMemoryManager(IntPtr @Opaque, LLVMMemoryManagerAllocateCodeSectionCallback @AllocateCodeSection, LLVMMemoryManagerAllocateDataSectionCallback @AllocateDataSection, LLVMMemoryManagerFinalizeMemoryCallback @FinalizeMemory, LLVMMemoryManagerDestroyCallback @Destroy);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeMCJITMemoryManager", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeMCJITMemoryManager(LLVMMCJITMemoryManagerRef @MM);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeTransformUtils", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeTransformUtils(LLVMPassRegistryRef @R);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeScalarOpts", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeScalarOpts(LLVMPassRegistryRef @R);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeObjCARCOpts", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeObjCARCOpts(LLVMPassRegistryRef @R);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeVectorization", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeVectorization(LLVMPassRegistryRef @R);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeInstCombine", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeInstCombine(LLVMPassRegistryRef @R);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeIPO", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeIPO(LLVMPassRegistryRef @R);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeInstrumentation", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeInstrumentation(LLVMPassRegistryRef @R);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeAnalysis", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeAnalysis(LLVMPassRegistryRef @R);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeIPA", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeIPA(LLVMPassRegistryRef @R);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeCodeGen", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeCodeGen(LLVMPassRegistryRef @R);

        [DllImport(libraryPath, EntryPoint = "LLVMInitializeTarget", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitializeTarget(LLVMPassRegistryRef @R);

        [DllImport(libraryPath, EntryPoint = "LLVMParseIRInContext", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool ParseIRInContext(LLVMContextRef @ContextRef, LLVMMemoryBufferRef @MemBuf, out LLVMModuleRef @OutM, out IntPtr @OutMessage);

        [DllImport(libraryPath, EntryPoint = "LLVMLinkModules", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool LinkModules(LLVMModuleRef @Dest, LLVMModuleRef @Src, uint @Unused, out IntPtr @OutMessage);

        [DllImport(libraryPath, EntryPoint = "llvm_create_optimizer", CallingConvention = CallingConvention.Cdecl)]
        public static extern llvm_lto_t llvm_create_optimizer();

        [DllImport(libraryPath, EntryPoint = "llvm_destroy_optimizer", CallingConvention = CallingConvention.Cdecl)]
        public static extern void llvm_destroy_optimizer(llvm_lto_t @lto);

        [DllImport(libraryPath, EntryPoint = "llvm_read_object_file", CallingConvention = CallingConvention.Cdecl)]
        public static extern llvm_lto_status llvm_read_object_file(llvm_lto_t @lto, [MarshalAs(UnmanagedType.LPStr)] string @input_filename);

        [DllImport(libraryPath, EntryPoint = "llvm_optimize_modules", CallingConvention = CallingConvention.Cdecl)]
        public static extern llvm_lto_status llvm_optimize_modules(llvm_lto_t @lto, [MarshalAs(UnmanagedType.LPStr)] string @output_filename);

        [DllImport(libraryPath, EntryPoint = "lto_get_version", CallingConvention = CallingConvention.Cdecl)]
        public static extern string lto_get_version();

        [DllImport(libraryPath, EntryPoint = "lto_get_error_message", CallingConvention = CallingConvention.Cdecl)]
        public static extern string lto_get_error_message();

        [DllImport(libraryPath, EntryPoint = "lto_module_is_object_file", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_bool_t lto_module_is_object_file([MarshalAs(UnmanagedType.LPStr)] string @path);

        [DllImport(libraryPath, EntryPoint = "lto_module_is_object_file_for_target", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_bool_t lto_module_is_object_file_for_target([MarshalAs(UnmanagedType.LPStr)] string @path, [MarshalAs(UnmanagedType.LPStr)] string @target_triple_prefix);

        [DllImport(libraryPath, EntryPoint = "lto_module_is_object_file_in_memory", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_bool_t lto_module_is_object_file_in_memory(IntPtr @mem, int @length);

        [DllImport(libraryPath, EntryPoint = "lto_module_is_object_file_in_memory_for_target", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_bool_t lto_module_is_object_file_in_memory_for_target(IntPtr @mem, int @length, [MarshalAs(UnmanagedType.LPStr)] string @target_triple_prefix);

        [DllImport(libraryPath, EntryPoint = "lto_module_create", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_module_t lto_module_create([MarshalAs(UnmanagedType.LPStr)] string @path);

        [DllImport(libraryPath, EntryPoint = "lto_module_create_from_memory", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_module_t lto_module_create_from_memory(IntPtr @mem, int @length);

        [DllImport(libraryPath, EntryPoint = "lto_module_create_from_memory_with_path", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_module_t lto_module_create_from_memory_with_path(IntPtr @mem, int @length, [MarshalAs(UnmanagedType.LPStr)] string @path);

        [DllImport(libraryPath, EntryPoint = "lto_module_create_in_local_context", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_module_t lto_module_create_in_local_context(IntPtr @mem, int @length, [MarshalAs(UnmanagedType.LPStr)] string @path);

        [DllImport(libraryPath, EntryPoint = "lto_module_create_in_codegen_context", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_module_t lto_module_create_in_codegen_context(IntPtr @mem, int @length, [MarshalAs(UnmanagedType.LPStr)] string @path, lto_code_gen_t @cg);

        [DllImport(libraryPath, EntryPoint = "lto_module_create_from_fd", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_module_t lto_module_create_from_fd(int @fd, [MarshalAs(UnmanagedType.LPStr)] string @path, int @file_size);

        [DllImport(libraryPath, EntryPoint = "lto_module_create_from_fd_at_offset", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_module_t lto_module_create_from_fd_at_offset(int @fd, [MarshalAs(UnmanagedType.LPStr)] string @path, int @file_size, int @map_size, int @offset);

        [DllImport(libraryPath, EntryPoint = "lto_module_dispose", CallingConvention = CallingConvention.Cdecl)]
        public static extern void lto_module_dispose(lto_module_t @mod);

        [DllImport(libraryPath, EntryPoint = "lto_module_get_target_triple", CallingConvention = CallingConvention.Cdecl)]
        public static extern string lto_module_get_target_triple(lto_module_t @mod);

        [DllImport(libraryPath, EntryPoint = "lto_module_set_target_triple", CallingConvention = CallingConvention.Cdecl)]
        public static extern void lto_module_set_target_triple(lto_module_t @mod, [MarshalAs(UnmanagedType.LPStr)] string @triple);

        [DllImport(libraryPath, EntryPoint = "lto_module_get_num_symbols", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint lto_module_get_num_symbols(lto_module_t @mod);

        [DllImport(libraryPath, EntryPoint = "lto_module_get_symbol_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string lto_module_get_symbol_name(lto_module_t @mod, uint @index);

        [DllImport(libraryPath, EntryPoint = "lto_module_get_symbol_attribute", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_symbol_attributes lto_module_get_symbol_attribute(lto_module_t @mod, uint @index);

        [DllImport(libraryPath, EntryPoint = "lto_module_get_num_deplibs", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint lto_module_get_num_deplibs(lto_module_t @mod);

        [DllImport(libraryPath, EntryPoint = "lto_module_get_deplib", CallingConvention = CallingConvention.Cdecl)]
        public static extern string lto_module_get_deplib(lto_module_t @mod, uint @index);

        [DllImport(libraryPath, EntryPoint = "lto_module_get_num_linkeropts", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint lto_module_get_num_linkeropts(lto_module_t @mod);

        [DllImport(libraryPath, EntryPoint = "lto_module_get_linkeropt", CallingConvention = CallingConvention.Cdecl)]
        public static extern string lto_module_get_linkeropt(lto_module_t @mod, uint @index);

        [DllImport(libraryPath, EntryPoint = "lto_codegen_set_diagnostic_handler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void lto_codegen_set_diagnostic_handler(lto_code_gen_t @param0, lto_diagnostic_handler_t @param1, IntPtr @param2);

        [DllImport(libraryPath, EntryPoint = "lto_codegen_create", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_code_gen_t lto_codegen_create();

        [DllImport(libraryPath, EntryPoint = "lto_codegen_create_in_local_context", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_code_gen_t lto_codegen_create_in_local_context();

        [DllImport(libraryPath, EntryPoint = "lto_codegen_dispose", CallingConvention = CallingConvention.Cdecl)]
        public static extern void lto_codegen_dispose(lto_code_gen_t @param0);

        [DllImport(libraryPath, EntryPoint = "lto_codegen_add_module", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_bool_t lto_codegen_add_module(lto_code_gen_t @cg, lto_module_t @mod);

        [DllImport(libraryPath, EntryPoint = "lto_codegen_set_debug_model", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_bool_t lto_codegen_set_debug_model(lto_code_gen_t @cg, lto_debug_model @param1);

        [DllImport(libraryPath, EntryPoint = "lto_codegen_set_pic_model", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_bool_t lto_codegen_set_pic_model(lto_code_gen_t @cg, lto_codegen_model @param1);

        [DllImport(libraryPath, EntryPoint = "lto_codegen_set_cpu", CallingConvention = CallingConvention.Cdecl)]
        public static extern void lto_codegen_set_cpu(lto_code_gen_t @cg, [MarshalAs(UnmanagedType.LPStr)] string @cpu);

        [DllImport(libraryPath, EntryPoint = "lto_codegen_set_assembler_path", CallingConvention = CallingConvention.Cdecl)]
        public static extern void lto_codegen_set_assembler_path(lto_code_gen_t @cg, [MarshalAs(UnmanagedType.LPStr)] string @path);

        [DllImport(libraryPath, EntryPoint = "lto_codegen_set_assembler_args", CallingConvention = CallingConvention.Cdecl)]
        public static extern void lto_codegen_set_assembler_args(lto_code_gen_t @cg, out IntPtr @args, int @nargs);

        [DllImport(libraryPath, EntryPoint = "lto_codegen_add_must_preserve_symbol", CallingConvention = CallingConvention.Cdecl)]
        public static extern void lto_codegen_add_must_preserve_symbol(lto_code_gen_t @cg, [MarshalAs(UnmanagedType.LPStr)] string @symbol);

        [DllImport(libraryPath, EntryPoint = "lto_codegen_write_merged_modules", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_bool_t lto_codegen_write_merged_modules(lto_code_gen_t @cg, [MarshalAs(UnmanagedType.LPStr)] string @path);

        [DllImport(libraryPath, EntryPoint = "lto_codegen_compile", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr lto_codegen_compile(lto_code_gen_t @cg, out int @length);

        [DllImport(libraryPath, EntryPoint = "lto_codegen_compile_to_file", CallingConvention = CallingConvention.Cdecl)]
        public static extern lto_bool_t lto_codegen_compile_to_file(lto_code_gen_t @cg, out IntPtr @name);

        [DllImport(libraryPath, EntryPoint = "lto_codegen_debug_options", CallingConvention = CallingConvention.Cdecl)]
        public static extern void lto_codegen_debug_options(lto_code_gen_t @cg, [MarshalAs(UnmanagedType.LPStr)] string @param1);

        [DllImport(libraryPath, EntryPoint = "lto_initialize_disassembler", CallingConvention = CallingConvention.Cdecl)]
        public static extern void lto_initialize_disassembler();

        [DllImport(libraryPath, EntryPoint = "LLVMCreateObjectFile", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMObjectFileRef CreateObjectFile(LLVMMemoryBufferRef @MemBuf);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeObjectFile", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeObjectFile(LLVMObjectFileRef @ObjectFile);

        [DllImport(libraryPath, EntryPoint = "LLVMGetSections", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMSectionIteratorRef GetSections(LLVMObjectFileRef @ObjectFile);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeSectionIterator", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeSectionIterator(LLVMSectionIteratorRef @SI);

        [DllImport(libraryPath, EntryPoint = "LLVMIsSectionIteratorAtEnd", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsSectionIteratorAtEnd(LLVMObjectFileRef @ObjectFile, LLVMSectionIteratorRef @SI);

        [DllImport(libraryPath, EntryPoint = "LLVMMoveToNextSection", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MoveToNextSection(LLVMSectionIteratorRef @SI);

        [DllImport(libraryPath, EntryPoint = "LLVMMoveToContainingSection", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MoveToContainingSection(LLVMSectionIteratorRef @Sect, LLVMSymbolIteratorRef @Sym);

        [DllImport(libraryPath, EntryPoint = "LLVMGetSymbols", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMSymbolIteratorRef GetSymbols(LLVMObjectFileRef @ObjectFile);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeSymbolIterator", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeSymbolIterator(LLVMSymbolIteratorRef @SI);

        [DllImport(libraryPath, EntryPoint = "LLVMIsSymbolIteratorAtEnd", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsSymbolIteratorAtEnd(LLVMObjectFileRef @ObjectFile, LLVMSymbolIteratorRef @SI);

        [DllImport(libraryPath, EntryPoint = "LLVMMoveToNextSymbol", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MoveToNextSymbol(LLVMSymbolIteratorRef @SI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetSectionName", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetSectionName(LLVMSectionIteratorRef @SI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetSectionSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetSectionSize(LLVMSectionIteratorRef @SI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetSectionContents", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetSectionContents(LLVMSectionIteratorRef @SI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetSectionAddress", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetSectionAddress(LLVMSectionIteratorRef @SI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetSectionContainsSymbol", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool GetSectionContainsSymbol(LLVMSectionIteratorRef @SI, LLVMSymbolIteratorRef @Sym);

        [DllImport(libraryPath, EntryPoint = "LLVMGetRelocations", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMRelocationIteratorRef GetRelocations(LLVMSectionIteratorRef @Section);

        [DllImport(libraryPath, EntryPoint = "LLVMDisposeRelocationIterator", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisposeRelocationIterator(LLVMRelocationIteratorRef @RI);

        [DllImport(libraryPath, EntryPoint = "LLVMIsRelocationIteratorAtEnd", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMBool IsRelocationIteratorAtEnd(LLVMSectionIteratorRef @Section, LLVMRelocationIteratorRef @RI);

        [DllImport(libraryPath, EntryPoint = "LLVMMoveToNextRelocation", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MoveToNextRelocation(LLVMRelocationIteratorRef @RI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetSymbolName", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetSymbolName(LLVMSymbolIteratorRef @SI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetSymbolAddress", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetSymbolAddress(LLVMSymbolIteratorRef @SI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetSymbolSize", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetSymbolSize(LLVMSymbolIteratorRef @SI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetRelocationAddress", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetRelocationAddress(LLVMRelocationIteratorRef @RI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetRelocationOffset", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetRelocationOffset(LLVMRelocationIteratorRef @RI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetRelocationSymbol", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMSymbolIteratorRef GetRelocationSymbol(LLVMRelocationIteratorRef @RI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetRelocationType", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetRelocationType(LLVMRelocationIteratorRef @RI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetRelocationTypeName", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetRelocationTypeName(LLVMRelocationIteratorRef @RI);

        [DllImport(libraryPath, EntryPoint = "LLVMGetRelocationValueString", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetRelocationValueString(LLVMRelocationIteratorRef @RI);

        [DllImport(libraryPath, EntryPoint = "LLVMAddArgumentPromotionPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddArgumentPromotionPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddConstantMergePass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddConstantMergePass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddDeadArgEliminationPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddDeadArgEliminationPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddFunctionAttrsPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddFunctionAttrsPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddFunctionInliningPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddFunctionInliningPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddAlwaysInlinerPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddAlwaysInlinerPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddGlobalDCEPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddGlobalDCEPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddGlobalOptimizerPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddGlobalOptimizerPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddIPConstantPropagationPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddIPConstantPropagationPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddPruneEHPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddPruneEHPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddIPSCCPPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddIPSCCPPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddInternalizePass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddInternalizePass(LLVMPassManagerRef @param0, uint @AllButMain);

        [DllImport(libraryPath, EntryPoint = "LLVMAddStripDeadPrototypesPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddStripDeadPrototypesPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddStripSymbolsPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddStripSymbolsPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMPassManagerBuilderCreate", CallingConvention = CallingConvention.Cdecl)]
        public static extern LLVMPassManagerBuilderRef PassManagerBuilderCreate();

        [DllImport(libraryPath, EntryPoint = "LLVMPassManagerBuilderDispose", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PassManagerBuilderDispose(LLVMPassManagerBuilderRef @PMB);

        [DllImport(libraryPath, EntryPoint = "LLVMPassManagerBuilderSetOptLevel", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PassManagerBuilderSetOptLevel(LLVMPassManagerBuilderRef @PMB, uint @OptLevel);

        [DllImport(libraryPath, EntryPoint = "LLVMPassManagerBuilderSetSizeLevel", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PassManagerBuilderSetSizeLevel(LLVMPassManagerBuilderRef @PMB, uint @SizeLevel);

        [DllImport(libraryPath, EntryPoint = "LLVMPassManagerBuilderSetDisableUnitAtATime", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PassManagerBuilderSetDisableUnitAtATime(LLVMPassManagerBuilderRef @PMB, LLVMBool @Value);

        [DllImport(libraryPath, EntryPoint = "LLVMPassManagerBuilderSetDisableUnrollLoops", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PassManagerBuilderSetDisableUnrollLoops(LLVMPassManagerBuilderRef @PMB, LLVMBool @Value);

        [DllImport(libraryPath, EntryPoint = "LLVMPassManagerBuilderSetDisableSimplifyLibCalls", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PassManagerBuilderSetDisableSimplifyLibCalls(LLVMPassManagerBuilderRef @PMB, LLVMBool @Value);

        [DllImport(libraryPath, EntryPoint = "LLVMPassManagerBuilderUseInlinerWithThreshold", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PassManagerBuilderUseInlinerWithThreshold(LLVMPassManagerBuilderRef @PMB, uint @Threshold);

        [DllImport(libraryPath, EntryPoint = "LLVMPassManagerBuilderPopulateFunctionPassManager", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PassManagerBuilderPopulateFunctionPassManager(LLVMPassManagerBuilderRef @PMB, LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMPassManagerBuilderPopulateModulePassManager", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PassManagerBuilderPopulateModulePassManager(LLVMPassManagerBuilderRef @PMB, LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMPassManagerBuilderPopulateLTOPassManager", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PassManagerBuilderPopulateLTOPassManager(LLVMPassManagerBuilderRef @PMB, LLVMPassManagerRef @PM, LLVMBool @Internalize, LLVMBool @RunInliner);

        [DllImport(libraryPath, EntryPoint = "LLVMAddAggressiveDCEPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddAggressiveDCEPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddAlignmentFromAssumptionsPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddAlignmentFromAssumptionsPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddCFGSimplificationPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddCFGSimplificationPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddDeadStoreEliminationPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddDeadStoreEliminationPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddScalarizerPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddScalarizerPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddMergedLoadStoreMotionPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddMergedLoadStoreMotionPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddGVNPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddGVNPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddIndVarSimplifyPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddIndVarSimplifyPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddInstructionCombiningPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddInstructionCombiningPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddJumpThreadingPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddJumpThreadingPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddLICMPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddLICMPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddLoopDeletionPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddLoopDeletionPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddLoopIdiomPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddLoopIdiomPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddLoopRotatePass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddLoopRotatePass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddLoopRerollPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddLoopRerollPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddLoopUnrollPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddLoopUnrollPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddLoopUnswitchPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddLoopUnswitchPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddMemCpyOptPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddMemCpyOptPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddPartiallyInlineLibCallsPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddPartiallyInlineLibCallsPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddLowerSwitchPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddLowerSwitchPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddPromoteMemoryToRegisterPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddPromoteMemoryToRegisterPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddReassociatePass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddReassociatePass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddSCCPPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddSCCPPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddScalarReplAggregatesPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddScalarReplAggregatesPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddScalarReplAggregatesPassSSA", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddScalarReplAggregatesPassSSA(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddScalarReplAggregatesPassWithThreshold", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddScalarReplAggregatesPassWithThreshold(LLVMPassManagerRef @PM, int @Threshold);

        [DllImport(libraryPath, EntryPoint = "LLVMAddSimplifyLibCallsPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddSimplifyLibCallsPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddTailCallEliminationPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddTailCallEliminationPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddConstantPropagationPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddConstantPropagationPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddDemoteMemoryToRegisterPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddDemoteMemoryToRegisterPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddVerifierPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddVerifierPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddCorrelatedValuePropagationPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddCorrelatedValuePropagationPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddEarlyCSEPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddEarlyCSEPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddLowerExpectIntrinsicPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddLowerExpectIntrinsicPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddTypeBasedAliasAnalysisPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddTypeBasedAliasAnalysisPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddScopedNoAliasAAPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddScopedNoAliasAAPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddBasicAliasAnalysisPass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddBasicAliasAnalysisPass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddBBVectorizePass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddBBVectorizePass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddLoopVectorizePass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddLoopVectorizePass(LLVMPassManagerRef @PM);

        [DllImport(libraryPath, EntryPoint = "LLVMAddSLPVectorizePass", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AddSLPVectorizePass(LLVMPassManagerRef @PM);

    }
}